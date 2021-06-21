using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class Option
    {
        [JsonPropertyName("addons")]
        public OptionAddon[] Addons { get; set; }

        [JsonPropertyName("agents")]
        public OptionAgent[] Agents { get; set; }

        [JsonPropertyName("carrierId")]
        public string CarrierId { get; set; }

        [JsonPropertyName("deliveryTime")]
        public string DeliveryTime { get; set; }

        [JsonPropertyName("description1")]
        public string Description1 { get; set; }

        [JsonPropertyName("description2")]
        public string Description2 { get; set; }

        [JsonPropertyName("description3")]
        public string Description3 { get; set; }

        [JsonPropertyName("description4")]
        public string Description4 { get; set; }

        [JsonPropertyName("description5")]
        public string Description5 { get; set; }

        [JsonPropertyName("description6")]
        public string Description6 { get; set; }

        [JsonPropertyName("fields")]
        public OptionField[] Fields { get; set; }

        [JsonPropertyName("genericKeyValues")]
        public OptionGenericKeyValue[] GenericKeyValues { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("noDefaultAgent")]
        public bool? NoDefaultAgent { get; set; }

        [JsonPropertyName("priceDescription")]
        public string PriceDescription { get; set; }

        [JsonPropertyName("priceValue")]
        public decimal? PriceValue { get; set; }

        [JsonPropertyName("serviceId")]
        public string ServiceId { get; set; }

        [JsonPropertyName("subOptions")]
        public SubOption[] SubOptions { get; set; }
    }
}