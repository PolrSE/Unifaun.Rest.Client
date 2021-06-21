using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Meta
{
    public partial class AddonValue
    {
        [JsonPropertyName("dataType")]
        public string DataType { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("validValues")]
        public string[] ValidValues { get; set; }
    }
}