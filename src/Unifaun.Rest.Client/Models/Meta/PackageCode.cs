using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Meta
{
    public partial class PackageCode
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}