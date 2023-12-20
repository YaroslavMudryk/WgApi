using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class BonusValues
    {
        [JsonPropertyName("value")]
        public float Value { get; set; }

        [JsonPropertyName("battle_type")]
        public string BattleType { get; set; }
    }
}
