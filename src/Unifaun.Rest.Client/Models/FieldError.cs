using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models
{
    public partial class FieldError
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("messageCode")]
        public string MessageCode { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }

}
