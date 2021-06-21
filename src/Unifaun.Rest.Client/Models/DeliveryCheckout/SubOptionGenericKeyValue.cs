using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class SubOptionGenericKeyValue
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("id")]
        public object Id { get; set; }
    }
}