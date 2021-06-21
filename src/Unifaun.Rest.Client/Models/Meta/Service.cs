using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Meta
{
    public partial class Service
    {
        [JsonPropertyName("addons")]
        public Addon[] Addons { get; set; }

        [JsonPropertyName("agent")]
        public Agent Agent { get; set; }

        [JsonPropertyName("customsPayer")]
        public CustomsPayer CustomsPayer { get; set; }

        [JsonPropertyName("delivery")]
        public Delivery Delivery { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("dispatch")]
        public Dispatch Dispatch { get; set; }

        [JsonPropertyName("freightPayer")]
        public FreightPayer FreightPayer { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("options")]
        public Option[] Options { get; set; }

        [JsonPropertyName("packageCodes")]
        public PackageCode[] PackageCodes { get; set; }

        [JsonPropertyName("printSet")]
        public string[] PrintSet { get; set; }

        [JsonPropertyName("receiver")]
        public Receiver Receiver { get; set; }

        [JsonPropertyName("returnPart")]
        public ReturnPart ReturnPart { get; set; }

        [JsonPropertyName("routes")]
        public ServiceRoute[] Routes { get; set; }

        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }

        [JsonPropertyName("taxPayer")]
        public TaxPayer TaxPayer { get; set; }

        [JsonPropertyName("uniqueDescription")]
        public string UniqueDescription { get; set; }
    }
}