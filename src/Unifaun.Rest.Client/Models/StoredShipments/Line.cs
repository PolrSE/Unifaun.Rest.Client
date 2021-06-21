using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class Line
    {
        [JsonPropertyName("certificates1")]
        public string Certificates1 { get; set; }

        [JsonPropertyName("certificates2")]
        public string Certificates2 { get; set; }

        [JsonPropertyName("certificates3")]
        public string Certificates3 { get; set; }

        [JsonPropertyName("certificatesCode1")]
        public string CertificatesCode1 { get; set; }

        [JsonPropertyName("certificatesCode2")]
        public string CertificatesCode2 { get; set; }

        [JsonPropertyName("certificatesCode3")]
        public string CertificatesCode3 { get; set; }

        [JsonPropertyName("contents")]
        public string Contents { get; set; }

        [JsonPropertyName("copies")]
        public long Copies { get; set; }

        [JsonPropertyName("goodsMark1")]
        public string GoodsMark1 { get; set; }

        [JsonPropertyName("goodsMark2")]
        public string GoodsMark2 { get; set; }

        [JsonPropertyName("goodsMark3")]
        public string GoodsMark3 { get; set; }

        [JsonPropertyName("goodsMark4")]
        public string GoodsMark4 { get; set; }

        [JsonPropertyName("goodsMark5")]
        public string GoodsMark5 { get; set; }

        [JsonPropertyName("goodsMark6")]
        public string GoodsMark6 { get; set; }

        [JsonPropertyName("grossWeight")]
        public decimal? GrossWeight { get; set; }

        [JsonPropertyName("netWeight")]
        public decimal? NetWeight { get; set; }

        [JsonPropertyName("otherQuantity")]
        public decimal? OtherQuantity { get; set; }

        [JsonPropertyName("otherUnit")]
        public string OtherUnit { get; set; }

        [JsonPropertyName("preference ")]
        public string Preference { get; set; }

        [JsonPropertyName("procedure")]
        public string Procedure { get; set; }

        [JsonPropertyName("sourceCountryCode")]
        public string SourceCountryCode { get; set; }

        [JsonPropertyName("statNo")]
        public string StatNo { get; set; }

        [JsonPropertyName("subStatNo1")]
        public string SubStatNo1 { get; set; }

        [JsonPropertyName("subStatNo2")]
        public string SubStatNo2 { get; set; }

        [JsonPropertyName("value")]
        public decimal? Value { get; set; }

        [JsonPropertyName("valuesPerItem")]
        public bool? ValuesPerItem { get; set; }

        [JsonPropertyName("yCode1")]
        public string YCode1 { get; set; }

        [JsonPropertyName("yCode2")]
        public string YCode2 { get; set; }

        [JsonPropertyName("yCode3")]
        public string YCode3 { get; set; }

        [JsonPropertyName("yCode4")]
        public string YCode4 { get; set; }

        [JsonPropertyName("yCode5")]
        public string YCode5 { get; set; }
    }
}