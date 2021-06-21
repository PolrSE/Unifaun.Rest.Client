using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class SubOptionAgent
    {
        [JsonPropertyName("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("distance")]
        public decimal? Distance { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("flags")]
        public string[] Flags { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("mapLatitude")]
        public decimal? MapLatitude { get; set; }

        [JsonPropertyName("mapLongitude")]
        public decimal? MapLongitude { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("openingHourSpecialDays")]
        public FluffyOpeningHourSpecialDay[] OpeningHourSpecialDays { get; set; }

        [JsonPropertyName("openingHourWeekdays")]
        public FluffyOpeningHourWeekday[] OpeningHourWeekdays { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("zipCode")]
        public string ZipCode { get; set; }
    }
}