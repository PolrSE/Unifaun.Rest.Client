using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Meta
{
    public partial class Addon
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("routes")]
        public AddonRoute[] Routes { get; set; }

        [JsonPropertyName("values")]
        public AddonValue[] Values { get; set; }
    }
}