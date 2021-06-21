using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class DeliveryCheckoutResponse
    {
        [JsonPropertyName("addons")]
        public DeliveryCheckoutResponseAddon[] Addons { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("deliveryCheckoutId")]
        public string DeliveryCheckoutId { get; set; }

        [JsonPropertyName("options")]
        public Option[] Options { get; set; }
    }
}
