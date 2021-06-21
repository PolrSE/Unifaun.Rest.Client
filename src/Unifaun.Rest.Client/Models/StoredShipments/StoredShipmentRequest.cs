using System;
using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class StoredShipmentRequest
    {
        [JsonPropertyName("agent")]
        public Agent Agent { get; set; }

        [JsonPropertyName("bulkId")]
        public string BulkId { get; set; }

        [JsonPropertyName("customLabelText1")]
        public string CustomLabelText1 { get; set; }

        [JsonPropertyName("customLabelText2")]
        public string CustomLabelText2 { get; set; }

        [JsonPropertyName("customLabelText3")]
        public string CustomLabelText3 { get; set; }

        [JsonPropertyName("customLabelText4")]
        public string CustomLabelText4 { get; set; }

        [JsonPropertyName("customLabelText5")]
        public string CustomLabelText5 { get; set; }

        [JsonPropertyName("customLabelText6")]
        public string CustomLabelText6 { get; set; }

        [JsonPropertyName("customsDeclaration")]
        public CustomsDeclaration CustomsDeclaration { get; set; }

        [JsonPropertyName("customsPayer")]
        public CustomsPayer CustomsPayer { get; set; }

        [JsonPropertyName("customsPayerPartners")]
        public CustomsPayerPartner[] CustomsPayerPartners { get; set; }

        [JsonPropertyName("delivery")]
        public Delivery Delivery { get; set; }

        [JsonPropertyName("deliveryDate")]
        public string DeliveryDate { get; set; }

        [JsonPropertyName("deliveryInstruction")]
        public string DeliveryInstruction { get; set; }

        [JsonPropertyName("deliveryTimeEarliest")]
        public string DeliveryTimeEarliest { get; set; }

        [JsonPropertyName("deliveryTimeLatest")]
        public string DeliveryTimeLatest { get; set; }

        [JsonPropertyName("developerId")]
        public string DeveloperId { get; set; }

        [JsonPropertyName("dispatch")]
        public Dispatch Dispatch { get; set; }

        [JsonPropertyName("ediForward")]
        public bool? EdiForward { get; set; }

        [JsonPropertyName("favorite")]
        public string Favorite { get; set; }

        [JsonPropertyName("freeText1")]
        public string FreeText1 { get; set; }

        [JsonPropertyName("freeText2")]
        public string FreeText2 { get; set; }

        [JsonPropertyName("freeText3")]
        public string FreeText3 { get; set; }

        [JsonPropertyName("freeText4")]
        public string FreeText4 { get; set; }

        [JsonPropertyName("freightPayer")]
        public FreightPayer FreightPayer { get; set; }

        [JsonPropertyName("freightPayerPartners")]
        public FreightPayerPartner[] FreightPayerPartners { get; set; }

        [JsonPropertyName("goodsDescription")]
        public string GoodsDescription { get; set; }

        [JsonPropertyName("linkPrintKey")]
        public string LinkPrintKey { get; set; }

        [JsonPropertyName("mergeId")]
        public string MergeId { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("options")]
        public Option[] Options { get; set; }

        [JsonPropertyName("orderNo")]
        public string OrderNo { get; set; }

        [JsonPropertyName("parcels")]
        public Parcel[] Parcels { get; set; }

        [JsonPropertyName("pdfInsert")]
        public string PdfInsert { get; set; }

        [JsonPropertyName("pickupTime")]
        public DateTimeOffset? PickupTime { get; set; }

        [JsonPropertyName("printSet")]
        public string[] PrintSet { get; set; }

        [JsonPropertyName("profileGroup")]
        public string ProfileGroup { get; set; }

        [JsonPropertyName("receiver")]
        public Receiver Receiver { get; set; }

        [JsonPropertyName("receiverPartners")]
        public ReceiverPartner[] ReceiverPartners { get; set; }

        [JsonPropertyName("receiverReference")]
        public string ReceiverReference { get; set; }

        [JsonPropertyName("returnPart")]
        public ReturnPart ReturnPart { get; set; }

        [JsonPropertyName("route")]
        public string Route { get; set; }

        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }

        [JsonPropertyName("senderPartners")]
        public SenderPartner[] SenderPartners { get; set; }

        [JsonPropertyName("senderReference")]
        public string SenderReference { get; set; }

        [JsonPropertyName("service")]
        public Service Service { get; set; }

        [JsonPropertyName("shipDate")]
        public DateTimeOffset? ShipDate { get; set; }

        [JsonPropertyName("shipmentNo")]
        public string ShipmentNo { get; set; }

        [JsonPropertyName("taxPayer")]
        public TaxPayer TaxPayer { get; set; }

        [JsonPropertyName("taxPayerPartners")]
        public TaxPayerPartner[] TaxPayerPartners { get; set; }

        [JsonPropertyName("termsCode")]
        public string TermsCode { get; set; }

        [JsonPropertyName("termsLocation")]
        public string TermsLocation { get; set; }

        [JsonPropertyName("termsLocationIdentifier")]
        public string TermsLocationIdentifier { get; set; }

        [JsonPropertyName("test")]
        public bool? Test { get; set; }

        [JsonPropertyName("totalEurPallets")]
        public long? TotalEurPallets { get; set; }

        [JsonPropertyName("totalHalfPallets")]
        public long? TotalHalfPallets { get; set; }

        [JsonPropertyName("totalLoadingMeters")]
        public decimal? TotalLoadingMeters { get; set; }

        [JsonPropertyName("totalPallets")]
        public long? TotalPallets { get; set; }

        [JsonPropertyName("totalPieces")]
        public long? TotalPieces { get; set; }

        [JsonPropertyName("totalQuantity")]
        public long? TotalQuantity { get; set; }

        [JsonPropertyName("totalQuarterPallets")]
        public long? TotalQuarterPallets { get; set; }

        [JsonPropertyName("totalSortCode")]
        public string TotalSortCode { get; set; }

        [JsonPropertyName("totalVolume")]
        public decimal? TotalVolume { get; set; }

        [JsonPropertyName("totalWeight")]
        public decimal? TotalWeight { get; set; }

        [JsonPropertyName("tplFormat")]
        public bool? TplFormat { get; set; }

        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("waybillCondition")]
        public string WaybillCondition { get; set; }

        [JsonPropertyName("waybillDocuments1")]
        public string WaybillDocuments1 { get; set; }

        [JsonPropertyName("waybillDocuments2")]
        public string WaybillDocuments2 { get; set; }

        [JsonPropertyName("waybillFreeText1")]
        public string WaybillFreeText1 { get; set; }

        [JsonPropertyName("waybillFreeText2")]
        public string WaybillFreeText2 { get; set; }

        [JsonPropertyName("waybillFreeText3")]
        public string WaybillFreeText3 { get; set; }

        [JsonPropertyName("waybillFreeText4")]
        public string WaybillFreeText4 { get; set; }

        [JsonPropertyName("waybillFreeText5")]
        public string WaybillFreeText5 { get; set; }

        [JsonPropertyName("waybillSpecialAgreement")]
        public string WaybillSpecialAgreement { get; set; }
    }
}
