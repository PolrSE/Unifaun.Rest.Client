using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Price
{
    public partial class Service
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}