using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Meta
{
    public partial class Agent
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("valid")]
        public bool Valid { get; set; }
    }
}