using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Meta
{
    public partial class Option
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("routes")]
        public OptionRoute[] Routes { get; set; }

        [JsonPropertyName("values")]
        public OptionValue[] Values { get; set; }
    }
}