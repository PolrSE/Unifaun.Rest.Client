using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Price
{
    public partial class Option
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("languageCode")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; }
    }
}