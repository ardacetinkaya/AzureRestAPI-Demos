namespace Azure.AppServicesStatus
{
    using Lib.ConsoleHelper;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(@"
      __ _ _____   _ _ __ ___ 
     / _` |_  / | | | '__/ _ \
    | (_| |/ /| |_| | | |  __/
     \__,_/___|\__,_|_|  \___|
            ");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();

            var azConfig = configuration.GetSection("AzureAD");

            var clientId = azConfig["CLIENTID"];
            var clientSecret = azConfig["CLIENTSECRET"];
            var tenantId = azConfig["TENANTID"];
            var subscription = azConfig["SUBSCRIPTION"];

            APICaller client = new APICaller(subscription, tenantId, clientId, clientSecret);
            if (await client.Login())
            {
                MenuItem selectedApp = new MenuItem();
                while (selectedApp != null)
                {
                    var response = await client.Get("https://management.azure.com/subscriptions/{subscriptionId}/providers/Microsoft.Web/sites?api-version=2019-08-01");

                    if (!string.IsNullOrEmpty(response))
                    {
                        var applications = AppServiceApplications.FromJson(response);
                        ChoiceMenu menu = new ChoiceMenu();
                        foreach (var item in applications.Value.OrderBy(o => o.Name))
                        {
                            menu.Options.Add(new MenuItem
                            {
                                Title = $"{item.Name.PadRight(50, ' ')}{item.Properties.State}",
                                Value = item.Id,
                            });
                        }
                        selectedApp = menu.ReadChoice(true);

                        //TODO: Do something with selected app


                    }
                }

            }
            else
            {
                Console.WriteLine("Please check your settings.");
            }
        }
    }
}
