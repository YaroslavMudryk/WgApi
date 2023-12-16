using System.Text.Json.Serialization;

namespace WgApi.Models.WotStatistics
{
    public class Historical : BaseStats
    {
        [JsonPropertyName("max_xp")]
        public int MaxXP { get; set; }

        [JsonPropertyName("max_damage_tank_id")]
        public object MaxDamageTankID { get; set; }

        [JsonPropertyName("max_xp_tank_id")]
        public object MaxXPTankID { get; set; }

        [JsonPropertyName("max_frags_tank_id")]
        public object MaxFragsTankID { get; set; }

        [JsonPropertyName("battle_avg_xp")]
        public int BattleAvgXP { get; set; }
    }
}
