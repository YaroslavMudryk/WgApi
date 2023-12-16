using System.Text.Json.Serialization;

namespace WgApi.Models.WotStatistics
{
    public class StrongholdSkirmish : BaseStats
    {
        [JsonPropertyName("max_xp")]
        public int MaxXP { get; set; }

        [JsonPropertyName("max_xp_tank_id")]
        public int MaxXPTankID { get; set; }

        [JsonPropertyName("max_frags_tank_id")]
        public int MaxFragsTankID { get; set; }

        [JsonPropertyName("max_damage_tank_id")]
        public int MaxDamageTankID { get; set; }

        [JsonPropertyName("battle_avg_xp")]
        public int BattleAvgXP { get; set; }
    }
}
