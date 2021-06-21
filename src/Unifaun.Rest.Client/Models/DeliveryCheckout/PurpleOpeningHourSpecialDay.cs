using System;
using System.Text.Json.Serialization;

namespace Unifaun.Rest.Client.Models.DeliveryCheckout
{
    public partial class PurpleOpeningHourSpecialDay
    {
        [JsonPropertyName("closed")]
        public bool? Closed { get; set; }

        [JsonPropertyName("date")]
        public DateTimeOffset? Date { get; set; }
    }
}