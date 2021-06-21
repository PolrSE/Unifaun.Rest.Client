using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class OptionAddon
    {
        [JsonPropertyName("at-least-one-ofs")]
        public string[] AtLeastOneOfs { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("excludes")]
        public string[] Excludes { get; set; }

        [JsonPropertyName("fields")]
        public FluffyField[] Fields { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("one-ofs")]
        public string[] OneOfs { get; set; }

        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        [JsonPropertyName("priceDescription")]
        public string PriceDescription { get; set; }

        [JsonPropertyName("selected")]
        public bool? Selected { get; set; }
    }
}