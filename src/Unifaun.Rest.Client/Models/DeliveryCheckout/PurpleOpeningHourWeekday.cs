using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class PurpleOpeningHourWeekday
    {
        [JsonPropertyName("closed")]
        public bool? Closed { get; set; }

        [JsonPropertyName("weekday")]
        public string Weekday { get; set; }
    }
}