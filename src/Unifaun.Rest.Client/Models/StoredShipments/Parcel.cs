using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class Parcel
    {
        [JsonPropertyName("articles")]
        public Article[] Articles { get; set; }

        [JsonPropertyName("contents")]
        public string Contents { get; set; }

        [JsonPropertyName("copies")]
        public long Copies { get; set; }

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

        [JsonPropertyName("dangerousGoods")]
        public ParcelDangerousGoods DangerousGoods { get; set; }

        [JsonPropertyName("height")]
        public decimal? Height { get; set; }

        [JsonPropertyName("itemNo")]
        public string ItemNo { get; set; }

        [JsonPropertyName("length")]
        public decimal? Length { get; set; }

        [JsonPropertyName("loadingMeters")]
        public decimal? LoadingMeters { get; set; }

        [JsonPropertyName("marking")]
        public string Marking { get; set; }

        [JsonPropertyName("packageCode")]
        public string PackageCode { get; set; }

        [JsonPropertyName("packageText")]
        public string PackageText { get; set; }

        [JsonPropertyName("parcelCountStart")]
        public long? ParcelCountStart { get; set; }

        [JsonPropertyName("parcelCountTotal")]
        public long? ParcelCountTotal { get; set; }

        [JsonPropertyName("parcelNos")]
        public string[] ParcelNos { get; set; }

        [JsonPropertyName("partOrderNo")]
        public string PartOrderNo { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("valuePerParcel")]
        public bool? ValuePerParcel { get; set; }

        [JsonPropertyName("volume")]
        public decimal? Volume { get; set; }

        [JsonPropertyName("weight")]
        public decimal? Weight { get; set; }

        [JsonPropertyName("width")]
        public decimal? Width { get; set; }
    }
}