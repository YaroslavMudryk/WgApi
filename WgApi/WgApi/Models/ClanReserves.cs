using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class ClanReserves
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("bonus_type")]
        public string BonusType { get; set; }

        [JsonPropertyName("disposable")]
        public bool Disposable { get; set; }

        [JsonPropertyName("in_stock")]
        public InStock[] InStock { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }

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

    public class BonusValues
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }

        [JsonPropertyName("battle_type")]
        public string BattleType { get; set; }
    }
}
