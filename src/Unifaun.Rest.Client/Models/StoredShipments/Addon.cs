using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class Addon
    {
        [JsonPropertyName("account")]
        public string Account { get; set; }

        [JsonPropertyName("accountType")]
        public string AccountType { get; set; }

        [JsonPropertyName("amount")]

        public decimal? Amount { get; set; }

        [JsonPropertyName("bank")]
        public string Bank { get; set; }

        [JsonPropertyName("cargoFlight")]
        public bool? CargoFlight { get; set; }

        [JsonPropertyName("confirmation")]
        public bool? Confirmation { get; set; }

        [JsonPropertyName("confirmationMisc")]
        public string ConfirmationMisc { get; set; }

        [JsonPropertyName("contact")]
        public string Contact { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("custNo")]
        public string CustNo { get; set; }

        [JsonPropertyName("custNoIssuerCode")]
        public string CustNoIssuerCode { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("declarant")]
        public string Declarant { get; set; }

        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("handoverDate")]
        public string HandoverDate { get; set; }

        [JsonPropertyName("handoverTime")]
        public string HandoverTime { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("length")]

        public decimal? Length { get; set; }

        [JsonPropertyName("misc")]
        public string Misc { get; set; }

        [JsonPropertyName("miscType")]
        public string MiscType { get; set; }

        [JsonPropertyName("passengerFlight")]
        public bool? PassengerFlight { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("referenceType")]
        public string ReferenceType { get; set; }

        [JsonPropertyName("tempMax")]
        public decimal? TempMax { get; set; }

        [JsonPropertyName("tempMin")]
        public decimal? TempMin { get; set; }

        [JsonPropertyName("text1")]
        public string Text1 { get; set; }

        [JsonPropertyName("text10")]
        public string Text10 { get; set; }

        [JsonPropertyName("text2")]
        public string Text2 { get; set; }

        [JsonPropertyName("text3")]
        public string Text3 { get; set; }

        [JsonPropertyName("text4")]
        public string Text4 { get; set; }

        [JsonPropertyName("text5")]
        public string Text5 { get; set; }

        [JsonPropertyName("text6")]
        public string Text6 { get; set; }

        [JsonPropertyName("text7")]
        public string Text7 { get; set; }

        [JsonPropertyName("text8")]
        public string Text8 { get; set; }

        [JsonPropertyName("text9")]
        public string Text9 { get; set; }

        [JsonPropertyName("timeFrom")]
        public string TimeFrom { get; set; }

        [JsonPropertyName("timeTo")]
        public string TimeTo { get; set; }

        [JsonPropertyName("width")]

        public decimal? Width { get; set; }
    }
}