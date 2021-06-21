using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class ArticleDangerousGoods
    {
        [JsonPropertyName("adrClass")]
        public string AdrClass { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("ems")]
        public string Ems { get; set; }

        [JsonPropertyName("flashPoint")]
        public string FlashPoint { get; set; }

        [JsonPropertyName("hazardCode")]
        public string HazardCode { get; set; }

        [JsonPropertyName("limitedQuantities")]
        public bool? LimitedQuantities { get; set; }

        [JsonPropertyName("mpCode")]
        public string MpCode { get; set; }

        [JsonPropertyName("netVolume")]
        public decimal? NetVolume { get; set; }

        [JsonPropertyName("netWeight")]
        public decimal? NetWeight { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("packageCode")]
        public string PackageCode { get; set; }

        [JsonPropertyName("packageType")]
        public string PackageType { get; set; }

        [JsonPropertyName("quantity")]
        public decimal? Quantity { get; set; }

        [JsonPropertyName("separation")]
        public string Separation { get; set; }

        [JsonPropertyName("technicalDescr")]
        public string TechnicalDescr { get; set; }

        [JsonPropertyName("trCode")]
        public string TrCode { get; set; }

        [JsonPropertyName("unCode")]
        public string UnCode { get; set; }
    }
}