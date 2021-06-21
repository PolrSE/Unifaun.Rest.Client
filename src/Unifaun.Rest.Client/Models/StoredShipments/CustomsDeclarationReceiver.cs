using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class CustomsDeclarationReceiver
    {
        [JsonPropertyName("addition")]
        public string Addition { get; set; }

        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("contact")]
        public string Contact { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("doorCode")]
        public string DoorCode { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        [JsonPropertyName("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("openingHours")]
        public string OpeningHours { get; set; }

        [JsonPropertyName("orgNo")]
        public string OrgNo { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("quickId")]
        public string QuickId { get; set; }

        [JsonPropertyName("serviceCode")]
        public string ServiceCode { get; set; }

        [JsonPropertyName("serviceType")]
        public string ServiceType { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("vatNo")]
        public string VatNo { get; set; }

        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }
    }
}