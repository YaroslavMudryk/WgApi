using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;

namespace WgApi.Models
{
    public class BattlesForStrongholdsStatistics
    {
        [JsonPropertyName("win_10")]
        public int Win10 { get; set; }

        [JsonPropertyName("total_10")]
        public int Total10 { get; set; }

        [JsonPropertyName("total_10_in_28d")]
        public int Total10In28D { get; set; }

        [JsonPropertyName("win_10_in_28d")]
        public int Win10In28D { get; set; }

        [JsonPropertyName("last_time_10")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? LastTime10 { get; set; }

        [JsonPropertyName("lose_10")]
        public int Lose10 { get; set; }
    }
}
