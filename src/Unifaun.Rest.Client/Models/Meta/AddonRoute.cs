using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Meta
{
    public partial class AddonRoute
    {
        [JsonPropertyName("from")]
        public string[] From { get; set; }

        [JsonPropertyName("to")]
        public string[] To { get; set; }
    }
}