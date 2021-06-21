using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class CustomsDeclaration
    {
        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("declarant")]
        public string Declarant { get; set; }

        [JsonPropertyName("declarantCity")]
        public string DeclarantCity { get; set; }

        [JsonPropertyName("declarantDate")]
        public string DeclarantDate { get; set; }

        [JsonPropertyName("declarationPayerId ")]
        public string DeclarationPayerId { get; set; }

        [JsonPropertyName("declarationReceiverId")]
        public string DeclarationReceiverId { get; set; }

        [JsonPropertyName("declarationSenderId")]
        public string DeclarationSenderId { get; set; }

        [JsonPropertyName("declarationTransactionType")]
        public string DeclarationTransactionType { get; set; }

        [JsonPropertyName("destinationCountryCode")]
        public string DestinationCountryCode { get; set; }

        [JsonPropertyName("discount")]
        public decimal? Discount { get; set; }

        [JsonPropertyName("edocNormal")]
        public bool? EdocNormal { get; set; }

        [JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        [JsonPropertyName("exportCountryCode")]
        public string ExportCountryCode { get; set; }

        [JsonPropertyName("exportDeclaration1")]
        public string ExportDeclaration1 { get; set; }

        [JsonPropertyName("exportDeclaration2")]
        public string ExportDeclaration2 { get; set; }

        [JsonPropertyName("exportLicenseNo")]
        public string ExportLicenseNo { get; set; }

        [JsonPropertyName("finance1")]
        public string Finance1 { get; set; }

        [JsonPropertyName("finance2")]
        public string Finance2 { get; set; }

        [JsonPropertyName("freightCharges")]
        public decimal? FreightCharges { get; set; }

        [JsonPropertyName("generalNote1")]
        public string GeneralNote1 { get; set; }

        [JsonPropertyName("generalNote2")]
        public string GeneralNote2 { get; set; }

        [JsonPropertyName("generalNote3")]
        public string GeneralNote3 { get; set; }

        [JsonPropertyName("generalNote4")]
        public string GeneralNote4 { get; set; }

        [JsonPropertyName("importExportType")]
        public string ImportExportType { get; set; }

        [JsonPropertyName("importLicenseNo")]
        public string ImportLicenseNo { get; set; }

        [JsonPropertyName("insuranceCharges")]
        public decimal? InsuranceCharges { get; set; }

        [JsonPropertyName("invoiceDeclaration1")]
        public string InvoiceDeclaration1 { get; set; }

        [JsonPropertyName("invoiceDeclaration2")]
        public string InvoiceDeclaration2 { get; set; }

        [JsonPropertyName("invoiceNo")]
        public string InvoiceNo { get; set; }

        [JsonPropertyName("invoiceType")]
        public string InvoiceType { get; set; }

        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }

        [JsonPropertyName("lines")]
        public Line[] Lines { get; set; }

        [JsonPropertyName("movementReferenceNo")]
        public string MovementReferenceNo { get; set; }

        [JsonPropertyName("otherCharges")]
        public decimal? OtherCharges { get; set; }

        [JsonPropertyName("parcelCount")]
        public long? ParcelCount { get; set; }

        [JsonPropertyName("printSet")]
        public string[] PrintSet { get; set; }

        [JsonPropertyName("receiver")]
        public CustomsDeclarationReceiver Receiver { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("representative1")]
        public string Representative1 { get; set; }

        [JsonPropertyName("representative2")]
        public string Representative2 { get; set; }

        [JsonPropertyName("representativeOrgNo")]
        public string RepresentativeOrgNo { get; set; }

        [JsonPropertyName("sender")]
        public CustomsDeclarationSender Sender { get; set; }

        [JsonPropertyName("shippingCodeBorder")]
        public string ShippingCodeBorder { get; set; }

        [JsonPropertyName("shippingCodeDomestic")]
        public string ShippingCodeDomestic { get; set; }

        [JsonPropertyName("sourceCountryCode")]
        public string SourceCountryCode { get; set; }

        [JsonPropertyName("termCode")]
        public string TermCode { get; set; }

        [JsonPropertyName("termLocation")]
        public string TermLocation { get; set; }

        [JsonPropertyName("termsOfPayment")]
        public string TermsOfPayment { get; set; }
    }
}