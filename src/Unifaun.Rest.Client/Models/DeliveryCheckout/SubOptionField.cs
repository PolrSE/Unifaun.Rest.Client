using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class SubOptionField
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("initialValue")]
        public string InitialValue { get; set; }

        [JsonPropertyName("mandatory")]
        public bool? Mandatory { get; set; }

        [JsonPropertyName("max")]
        public long? Max { get; set; }

        [JsonPropertyName("min")]
        public long? Min { get; set; }

        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}