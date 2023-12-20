using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class InStock
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("action_time")]
        public int? ActionTime { get; set; }

        [JsonPropertyName("active_till")]
        public object ActiveTill { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("activated_at")]
        public object ActivatedAt { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("bonus_values")]
        public BonusValues[] BonusValues { get; set; }

        [JsonPropertyName("x_level_only")]
        public bool XLevelOnly { get; set; }
    }
}
