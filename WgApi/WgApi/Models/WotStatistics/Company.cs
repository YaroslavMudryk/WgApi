using System.Text.Json.Serialization;

namespace WgApi.Models.WotStatistics
{
    public class Company : BaseStats
    {
        [JsonPropertyName("battle_avg_xp")]
        public int BattleAvgXP { get; set; }
    }
}
