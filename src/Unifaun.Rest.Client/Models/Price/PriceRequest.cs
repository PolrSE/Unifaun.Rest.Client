using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Price
{
    public partial class PriceRequest
    {
        [JsonPropertyName("additionalSurcharges")]
        public AdditionalSurcharges AdditionalSurcharges { get; set; }

        [JsonPropertyName("shipment")]
        public Shipment Shipment { get; set; }
    }
}
