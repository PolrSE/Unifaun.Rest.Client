using System.Text.Json.Serialization;
using Unifaun.Rest.Client.Models.StoredShipments;

namespace Unifaun.Rest.Client.Models.Price
{
    public partial class Shipment
    {
        [JsonPropertyName("sender")]
        public Sender Sender { get; set; }

        [JsonPropertyName("parcels")]
        public Parcel[] Parcels { get; set; }

        [JsonPropertyName("orderNo")]
        public string OrderNo { get; set; }

        [JsonPropertyName("receiver")]
        public Receiver Receiver { get; set; }

        [JsonPropertyName("senderReference")]
        public string SenderReference { get; set; }

        [JsonPropertyName("service")]
        public Service Service { get; set; }

        [JsonPropertyName("receiverReference")]
        public string ReceiverReference { get; set; }

        [JsonPropertyName("options")]
        public Option[] Options { get; set; }

        [JsonPropertyName("goodsDescription")]
        public string GoodsDescription { get; set; }

        [JsonPropertyName("customsDeclaration")]
        public CustomsDeclaration CustomsDeclaration { get; set; }
    }
}