using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class BattlesSeriesForStrongholdsStatistics
    {
        [JsonPropertyName("win_10")]
        public int Win10 { get; set; }

        [JsonPropertyName("total_10")]
        public int Total10 { get; set; }

        [JsonPropertyName("total_10_in_28d")]
        public int Total10In28D { get; set; }

        [JsonPropertyName("win_10_in_28d")]
        public int Win10In28D { get; set; }

        [JsonPropertyName("lose_10")]
        public int Lose10 { get; set; }
    }
}
