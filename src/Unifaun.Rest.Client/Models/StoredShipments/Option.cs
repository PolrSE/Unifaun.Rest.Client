using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class Option
    {
        [JsonPropertyName("bcc")]
        public string Bcc { get; set; }

        [JsonPropertyName("cc")]
        public string Cc { get; set; }

        [JsonPropertyName("errorTo")]
        public string ErrorTo { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("languageCode")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("mailTemplate")]
        public string MailTemplate { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("sendEmail")]
        public bool? SendEmail { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }
    }
}