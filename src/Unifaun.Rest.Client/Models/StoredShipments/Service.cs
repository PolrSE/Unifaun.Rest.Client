using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class Service
    {
        [JsonPropertyName("addons")]
        public Addon[] Addons { get; set; }

        [JsonPropertyName("bookingId")]
        public string BookingId { get; set; }

        [JsonPropertyName("bookingOffice")]
        public string BookingOffice { get; set; }

        [JsonPropertyName("contractVersion")]
        public string ContractVersion { get; set; }

        [JsonPropertyName("destinationLocation")]
        public string DestinationLocation { get; set; }

        [JsonPropertyName("externalIdentifier")]
        public string ExternalIdentifier { get; set; }

        [JsonPropertyName("handOverCode")]
        public string HandOverCode { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("infoCode")]
        public string InfoCode { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nonDeliveryType")]
        public string NonDeliveryType { get; set; }

        [JsonPropertyName("normalShipment")]
        public bool? NormalShipment { get; set; }

        [JsonPropertyName("notifyCode1")]
        public string NotifyCode1 { get; set; }

        [JsonPropertyName("notifyCode2")]
        public string NotifyCode2 { get; set; }

        [JsonPropertyName("notifyCode3")]
        public string NotifyCode3 { get; set; }

        [JsonPropertyName("paymentMethodType")]
        public string PaymentMethodType { get; set; }

        [JsonPropertyName("pickupBooking")]
        public bool? PickupBooking { get; set; }

        [JsonPropertyName("pickupDate")]
        public string PickupDate { get; set; }

        [JsonPropertyName("pickupMisc")]
        public string PickupMisc { get; set; }

        [JsonPropertyName("pickupText1")]
        public string PickupText1 { get; set; }

        [JsonPropertyName("pickupTimeFrom")]
        public string PickupTimeFrom { get; set; }

        [JsonPropertyName("pickupTimeTo")]
        public string PickupTimeTo { get; set; }

        [JsonPropertyName("referenceAsBarcode")]
        public bool? ReferenceAsBarcode { get; set; }

        [JsonPropertyName("returnShipment")]
        public bool? ReturnShipment { get; set; }

        [JsonPropertyName("shipperLoadAndCount")]
        public long? ShipperLoadAndCount { get; set; }

        [JsonPropertyName("sortPos")]
        public string SortPos { get; set; }

        [JsonPropertyName("subId")]
        public string SubId { get; set; }

        [JsonPropertyName("terminal")]
        public string Terminal { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("valueAmount")]
        public string ValueAmount { get; set; }

        [JsonPropertyName("valueCurrencyCode")]
        public string ValueCurrencyCode { get; set; }

        [JsonPropertyName("waybillCod")]
        public long? WaybillCod { get; set; }

        [JsonPropertyName("waybillCod342")]
        public long? WaybillCod342 { get; set; }

        [JsonPropertyName("waybillEurCertificate")]
        public long? WaybillEurCertificate { get; set; }

        [JsonPropertyName("waybillExportNotification")]
        public long? WaybillExportNotification { get; set; }

        [JsonPropertyName("waybillHomeDelivery342")]
        public long? WaybillHomeDelivery342 { get; set; }

        [JsonPropertyName("waybillInvoice")]
        public long? WaybillInvoice { get; set; }

        [JsonPropertyName("waybillUnits332")]
        public long? WaybillUnits332 { get; set; }

        [JsonPropertyName("waybillUnits334")]
        public long? WaybillUnits334 { get; set; }

        [JsonPropertyName("waybillUnits336")]
        public long? WaybillUnits336 { get; set; }

        [JsonPropertyName("waybillUnits342")]
        public long? WaybillUnits342 { get; set; }

        [JsonPropertyName("waybillUnits370")]
        public long? WaybillUnits370 { get; set; }

        [JsonPropertyName("waybillWeight332")]

        public decimal? WaybillWeight332 { get; set; }

        [JsonPropertyName("waybillWeight334")]

        public decimal? WaybillWeight334 { get; set; }

        [JsonPropertyName("waybillWeight336")]

        public decimal? WaybillWeight336 { get; set; }

        [JsonPropertyName("waybillWeight342")]

        public decimal? WaybillWeight342 { get; set; }

        [JsonPropertyName("waybillWeight370")]

        public decimal? WaybillWeight370 { get; set; }
    }
}