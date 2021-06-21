using System;
using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class StoredShipmentResponse : IBaseResponse
    {
        [JsonPropertyName("addons")]
        public string[] Addons { get; set; }

        [JsonPropertyName("changed")]
        public DateTimeOffset? Changed { get; set; }

        [JsonPropertyName("created")]
        public DateTimeOffset? Created { get; set; }

        [JsonPropertyName("href")]
        public string Href { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("normalShipment")]
        public bool? NormalShipment { get; set; }

        [JsonPropertyName("orderNo")]
        public string OrderNo { get; set; }

        [JsonPropertyName("parcelCount")]
        public long? ParcelCount { get; set; }

        [JsonPropertyName("rcvCity")]
        public string RcvCity { get; set; }

        [JsonPropertyName("rcvCountry")]
        public string RcvCountry { get; set; }

        [JsonPropertyName("rcvName")]
        public string RcvName { get; set; }

        [JsonPropertyName("rcvZipcode")]
        public string RcvZipcode { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("returnShipment")]
        public bool? ReturnShipment { get; set; }

        [JsonPropertyName("serviceId")]
        public string ServiceId { get; set; }

        [JsonPropertyName("shipDate")]
        public DateTimeOffset? ShipDate { get; set; }

        [JsonPropertyName("sndCity")]
        public string SndCity { get; set; }

        [JsonPropertyName("sndCountry")]
        public string SndCountry { get; set; }

        [JsonPropertyName("sndName")]
        public string SndName { get; set; }

        [JsonPropertyName("sndZipcode")]
        public string SndZipcode { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("statuses")]
        public Status[] Statuses { get; set; }

        public string JsonData { get; set; }
    }
}
