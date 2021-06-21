using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.StoredShipments
{
    public partial class Article
    {
        [JsonPropertyName("articleNo")]
        public string ArticleNo { get; set; }

        [JsonPropertyName("contents")]
        public string Contents { get; set; }

        [JsonPropertyName("count")]
        public long? Count { get; set; }

        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("customsContents")]
        public string CustomsContents { get; set; }

        [JsonPropertyName("customsNetWeight")]

        public decimal? CustomsNetWeight { get; set; }

        [JsonPropertyName("customsOtherQuantity")]

        public decimal? CustomsOtherQuantity { get; set; }

        [JsonPropertyName("customsOtherUnit")]
        public string CustomsOtherUnit { get; set; }

        [JsonPropertyName("customsSourceCountryCode")]
        public string CustomsSourceCountryCode { get; set; }

        [JsonPropertyName("customsStatNo")]
        public string CustomsStatNo { get; set; }

        [JsonPropertyName("customsSubStatNo1")]
        public string CustomsSubStatNo1 { get; set; }

        [JsonPropertyName("customsValue")]

        public decimal? CustomsValue { get; set; }

        [JsonPropertyName("dangerousGoods")]
        public ArticleDangerousGoods DangerousGoods { get; set; }

        [JsonPropertyName("enot")]
        public bool? Enot { get; set; }

        [JsonPropertyName("loadingMeters")]

        public decimal? LoadingMeters { get; set; }

        [JsonPropertyName("marking")]
        public string Marking { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("packageCode")]
        public string PackageCode { get; set; }

        [JsonPropertyName("price")]

        public decimal? Price { get; set; }

        [JsonPropertyName("volume")]

        public decimal? Volume { get; set; }

        [JsonPropertyName("weight")]

        public decimal? Weight { get; set; }
    }
}