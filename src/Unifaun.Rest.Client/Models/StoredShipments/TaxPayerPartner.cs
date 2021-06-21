using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class TaxPayerPartner
    {
        [JsonPropertyName("additionalCarrierLabel")]
        public bool? AdditionalCarrierLabel { get; set; }

        [JsonPropertyName("agentNo")]
        public string AgentNo { get; set; }

        [JsonPropertyName("bookingEmail")]
        public string BookingEmail { get; set; }

        [JsonPropertyName("bookingId")]
        public string BookingId { get; set; }

        [JsonPropertyName("bookingOffice")]
        public string BookingOffice { get; set; }

        [JsonPropertyName("custNo")]
        public string CustNo { get; set; }

        [JsonPropertyName("custNoIssuerCode")]
        public string CustNoIssuerCode { get; set; }

        [JsonPropertyName("ediAddress")]
        public string EdiAddress { get; set; }

        [JsonPropertyName("ediKey")]
        public string EdiKey { get; set; }

        [JsonPropertyName("ediPassword")]
        public string EdiPassword { get; set; }

        [JsonPropertyName("ediUserId")]
        public string EdiUserId { get; set; }

        [JsonPropertyName("externalIdentifier")]
        public string ExternalIdentifier { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("infoCode")]
        public string InfoCode { get; set; }

        [JsonPropertyName("palletRegNo")]
        public string PalletRegNo { get; set; }

        [JsonPropertyName("priceEnquiry")]
        public string PriceEnquiry { get; set; }

        [JsonPropertyName("priceEnquiryPassword")]
        public string PriceEnquiryPassword { get; set; }

        [JsonPropertyName("senderId")]
        public string SenderId { get; set; }

        [JsonPropertyName("sourceCode")]
        public string SourceCode { get; set; }
    }
}