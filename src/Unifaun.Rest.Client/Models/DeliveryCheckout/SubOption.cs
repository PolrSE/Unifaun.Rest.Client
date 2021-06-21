using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class SubOption
    {
        [JsonPropertyName("addons")]
        public SubOptionAddon[] Addons { get; set; }

        [JsonPropertyName("agents")]
        public SubOptionAgent[] Agents { get; set; }

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

        [JsonPropertyName("fields")]
        public SubOptionField[] Fields { get; set; }

        [JsonPropertyName("genericKeyValues")]
        public SubOptionGenericKeyValue[] GenericKeyValues { get; set; }

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
    }
}