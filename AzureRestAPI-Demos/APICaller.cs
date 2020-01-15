namespace Azure.AppServicesStatus
{
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    class APICaller
    {
        private string _token = string.Empty;


        private readonly string _subscription = string.Empty;
        private readonly string _tenantId = string.Empty;
        private readonly string _clientId = string.Empty;
        private readonly string _clientKey = string.Empty;
        public APICaller(string subscription, string tenantId, string clientId, string clientKey)
        {
            _subscription = subscription;
            _tenantId = tenantId;
            _clientId = clientId;
            _clientKey = clientKey;
        }
        public async Task<bool> Login()
        {
            try
            {
                string authContextURL = $"https://login.windows.net/{_tenantId}";
                var authenticationContext = new AuthenticationContext(authContextURL);
                var credential = new ClientCredential(_clientId, _clientKey);
                var result = await authenticationContext
                    .AcquireTokenAsync("https://management.azure.com/", credential);

                if (result == null)
                {
                    return false;
                }
                _token = result.AccessToken;

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<string> Get(string URI)
        {
            if (string.IsNullOrEmpty(URI)) throw new ArgumentNullException(nameof(URI));

            if (string.IsNullOrEmpty(_token)) throw new ArgumentNullException(nameof(_token));


            using (var client = new HttpClient())
            {
                URI = URI.Trim().Replace("{subscriptionId}", _subscription);

                client.DefaultRequestHeaders.Remove("Authorization");
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");

                HttpResponseMessage response = await client.GetAsync(URI);

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
