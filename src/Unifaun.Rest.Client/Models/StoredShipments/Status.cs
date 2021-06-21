using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class Status
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("messageCode")]
        public string MessageCode { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}