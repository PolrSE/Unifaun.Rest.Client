using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Price
{
    public partial class AdditionalSurcharges
    {
        [JsonPropertyName("percent")]
        public decimal Percent { get; set; }

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
    }
}