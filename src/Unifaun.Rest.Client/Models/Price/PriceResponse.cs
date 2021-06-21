using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Price
{
    public class PriceResponse
    {
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("additionalSurcharges")]
        public decimal AdditionalSurcharges { get; set; }

        [JsonPropertyName("priceWithAdditionalSurcharges")]
        public decimal PriceWithAdditionalSurcharges { get; set; }
    }
}
