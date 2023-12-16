using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class TankStatistics
    {
        [JsonPropertyName("statistics")]
        public TankDetailStatistic Statistics { get; set; }
        [JsonPropertyName("mark_of_mastery")]
        public int MarkOfMastery { get; set; }
        [JsonPropertyName("tank_id")]
        public int TankId { get; set; }
    }

    public class TankDetailStatistic
    {
        [JsonPropertyName("wins")]
        public int Wins { get; set; }
        [JsonPropertyName("battles")]
        public int Battles { get; set; }
    }
}
