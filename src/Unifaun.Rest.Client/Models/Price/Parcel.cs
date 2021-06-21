using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.Price
{
    public partial class Parcel
    {
        [JsonPropertyName("copies")]
        public long Copies { get; set; }

        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

        [JsonPropertyName("contents")]
        public string Contents { get; set; }

        [JsonPropertyName("valuePerParcel")]
        public bool ValuePerParcel { get; set; }
    }
}