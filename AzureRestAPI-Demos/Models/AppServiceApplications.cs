namespace Azure.AppServicesStatus
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AppServiceApplications
    {
        [JsonProperty("value")]
        public List<App> Value { get; set; }
    }

    public partial class App
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

    }

    public partial class Properties
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("hostNames")]
        public List<string> HostNames { get; set; }

        [JsonProperty("webSpace")]
        public string WebSpace { get; set; }

        [JsonProperty("selfLink")]
        public Uri SelfLink { get; set; }

        [JsonProperty("repositorySiteName")]
        public string RepositorySiteName { get; set; }

        [JsonProperty("owner")]
        public object Owner { get; set; }

        [JsonProperty("usageState")]
        public string UsageState { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("adminEnabled")]
        public bool AdminEnabled { get; set; }

        [JsonProperty("enabledHostNames")]
        public List<string> EnabledHostNames { get; set; }

        [JsonProperty("siteProperties")]
        public SiteProperties SiteProperties { get; set; }

        [JsonProperty("availabilityState")]
        public string AvailabilityState { get; set; }

        [JsonProperty("sslCertificates")]
        public List<object> SslCertificates { get; set; }

        [JsonProperty("csrs")]
        public List<object> Csrs { get; set; }

        [JsonProperty("cers")]
        public object Cers { get; set; }

        [JsonProperty("siteMode")]
        public string SiteMode { get; set; }

        [JsonProperty("hostNameSslStates")]
        public List<HostNameSslState> HostNameSslStates { get; set; }

        [JsonProperty("computeMode")]
        public string ComputeMode { get; set; }

        [JsonProperty("serverFarm")]
        public object ServerFarm { get; set; }

        [JsonProperty("serverFarmId")]
        public string ServerFarmId { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("isXenon")]
        public bool IsXenon { get; set; }

        [JsonProperty("hyperV")]
        public bool HyperV { get; set; }

        [JsonProperty("lastModifiedTimeUtc")]
        public DateTimeOffset LastModifiedTimeUtc { get; set; }

        [JsonProperty("storageRecoveryDefaultState")]
        public string StorageRecoveryDefaultState { get; set; }

        [JsonProperty("contentAvailabilityState")]
        public string ContentAvailabilityState { get; set; }

        [JsonProperty("runtimeAvailabilityState")]
        public string RuntimeAvailabilityState { get; set; }

        [JsonProperty("siteConfig")]
        public object SiteConfig { get; set; }

        [JsonProperty("deploymentId")]
        public string DeploymentId { get; set; }

        [JsonProperty("trafficManagerHostNames")]
        public object TrafficManagerHostNames { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("scmSiteAlsoStopped")]
        public bool ScmSiteAlsoStopped { get; set; }

        [JsonProperty("targetSwapSlot")]
        public object TargetSwapSlot { get; set; }

        [JsonProperty("hostingEnvironment")]
        public object HostingEnvironment { get; set; }

        [JsonProperty("hostingEnvironmentProfile")]
        public object HostingEnvironmentProfile { get; set; }

        [JsonProperty("clientAffinityEnabled")]
        public bool ClientAffinityEnabled { get; set; }

        [JsonProperty("clientCertEnabled")]
        public bool ClientCertEnabled { get; set; }

        [JsonProperty("clientCertExclusionPaths")]
        public object ClientCertExclusionPaths { get; set; }

        [JsonProperty("hostNamesDisabled")]
        public bool HostNamesDisabled { get; set; }

        [JsonProperty("domainVerificationIdentifiers")]
        public object DomainVerificationIdentifiers { get; set; }

        [JsonProperty("customDomainVerificationId")]
        public string CustomDomainVerificationId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("inboundIpAddress")]
        public string InboundIpAddress { get; set; }

        [JsonProperty("possibleInboundIpAddresses")]
        public string PossibleInboundIpAddresses { get; set; }

        [JsonProperty("outboundIpAddresses")]
        public string OutboundIpAddresses { get; set; }

        [JsonProperty("possibleOutboundIpAddresses")]
        public string PossibleOutboundIpAddresses { get; set; }

        [JsonProperty("containerSize")]
        public long ContainerSize { get; set; }

        [JsonProperty("dailyMemoryTimeQuota")]
        public long DailyMemoryTimeQuota { get; set; }

        [JsonProperty("suspendedTill")]
        public object SuspendedTill { get; set; }

        [JsonProperty("siteDisabledReason")]
        public long SiteDisabledReason { get; set; }

        [JsonProperty("functionExecutionUnitsCache")]
        public object FunctionExecutionUnitsCache { get; set; }

        [JsonProperty("maxNumberOfWorkers")]
        public object MaxNumberOfWorkers { get; set; }

        [JsonProperty("homeStamp")]
        public string HomeStamp { get; set; }

        [JsonProperty("cloningInfo")]
        public object CloningInfo { get; set; }

        [JsonProperty("hostingEnvironmentId")]
        public object HostingEnvironmentId { get; set; }

        [JsonProperty("resourceGroup")]
        public string ResourceGroup { get; set; }

        [JsonProperty("defaultHostName")]
        public string DefaultHostName { get; set; }

        [JsonProperty("slotSwapStatus")]
        public object SlotSwapStatus { get; set; }

        [JsonProperty("httpsOnly")]
        public bool HttpsOnly { get; set; }

        [JsonProperty("redundancyMode")]
        public string RedundancyMode { get; set; }

        [JsonProperty("inProgressOperationId")]
        public object InProgressOperationId { get; set; }

        [JsonProperty("geoDistributions")]
        public object GeoDistributions { get; set; }

        [JsonProperty("privateEndpointConnections")]
        public object PrivateEndpointConnections { get; set; }

        [JsonProperty("buildVersion")]
        public object BuildVersion { get; set; }

        [JsonProperty("targetBuildVersion")]
        public object TargetBuildVersion { get; set; }
    }

    public partial class HostNameSslState
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sslState")]
        public SslState SslState { get; set; }

        [JsonProperty("ipBasedSslResult")]
        public object IpBasedSslResult { get; set; }

        [JsonProperty("virtualIP")]
        public object VirtualIp { get; set; }

        [JsonProperty("thumbprint")]
        public string Thumbprint { get; set; }

        [JsonProperty("toUpdate")]
        public object ToUpdate { get; set; }

        [JsonProperty("toUpdateIpBasedSsl")]
        public object ToUpdateIpBasedSsl { get; set; }

        [JsonProperty("ipBasedSslState")]
        public IpBasedSslState IpBasedSslState { get; set; }

        [JsonProperty("hostType")]
        public HostType HostType { get; set; }
    }

    public partial class SiteProperties
    {
        [JsonProperty("metadata")]
        public object Metadata { get; set; }

        [JsonProperty("properties")]
        public List<Property> Properties { get; set; }

        [JsonProperty("appSettings")]
        public object AppSettings { get; set; }
    }

    public partial class Property
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum HostType { Repository, Standard };

    public enum IpBasedSslState { NotConfigured };

    public enum SslState { Disabled, SniEnabled };

    public enum Name { LinuxFxVersion, WindowsFxVersion };

    public partial class AppServiceApplications
    {
        public static AppServiceApplications FromJson(string json) => JsonConvert.DeserializeObject<AppServiceApplications>(json, Azure.AppServicesStatus.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AppServiceApplications self) => JsonConvert.SerializeObject(self, Azure.AppServicesStatus.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                HostTypeConverter.Singleton,
                IpBasedSslStateConverter.Singleton,
                SslStateConverter.Singleton,
                NameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class HostTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HostType) || t == typeof(HostType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Repository":
                    return HostType.Repository;
                case "Standard":
                    return HostType.Standard;
            }
            throw new Exception("Cannot unmarshal type HostType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HostType)untypedValue;
            switch (value)
            {
                case HostType.Repository:
                    serializer.Serialize(writer, "Repository");
                    return;
                case HostType.Standard:
                    serializer.Serialize(writer, "Standard");
                    return;
            }
            throw new Exception("Cannot marshal type HostType");
        }

        public static readonly HostTypeConverter Singleton = new HostTypeConverter();
    }

    internal class IpBasedSslStateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IpBasedSslState) || t == typeof(IpBasedSslState?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "NotConfigured")
            {
                return IpBasedSslState.NotConfigured;
            }
            throw new Exception("Cannot unmarshal type IpBasedSslState");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IpBasedSslState)untypedValue;
            if (value == IpBasedSslState.NotConfigured)
            {
                serializer.Serialize(writer, "NotConfigured");
                return;
            }
            throw new Exception("Cannot marshal type IpBasedSslState");
        }

        public static readonly IpBasedSslStateConverter Singleton = new IpBasedSslStateConverter();
    }

    internal class SslStateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SslState) || t == typeof(SslState?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Disabled":
                    return SslState.Disabled;
                case "SniEnabled":
                    return SslState.SniEnabled;
            }
            throw new Exception("Cannot unmarshal type SslState");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SslState)untypedValue;
            switch (value)
            {
                case SslState.Disabled:
                    serializer.Serialize(writer, "Disabled");
                    return;
                case SslState.SniEnabled:
                    serializer.Serialize(writer, "SniEnabled");
                    return;
            }
            throw new Exception("Cannot marshal type SslState");
        }

        public static readonly SslStateConverter Singleton = new SslStateConverter();
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "LinuxFxVersion":
                    return Name.LinuxFxVersion;
                case "WindowsFxVersion":
                    return Name.WindowsFxVersion;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.LinuxFxVersion:
                    serializer.Serialize(writer, "LinuxFxVersion");
                    return;
                case Name.WindowsFxVersion:
                    serializer.Serialize(writer, "WindowsFxVersion");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }
}
