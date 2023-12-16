using System.Text.Json.Serialization;

namespace WgApi.Models.WotStatistics
{
    public class BaseStats
    {
        [JsonPropertyName("spotted")]
        public int Spotted { get; set; }

        [JsonPropertyName("battles_on_stunning_vehicles")]
        public int BattlesOnStunningVehicles { get; set; }

        [JsonPropertyName("max_xp")]
        public int MaxXp { get; set; }

        [JsonPropertyName("avg_damage_blocked")]
        public float AvgDamageBlocked { get; set; }

        [JsonPropertyName("direct_hits_received")]
        public int DirectHitsReceived { get; set; }

        [JsonPropertyName("explosion_hits")]
        public int ExplosionHits { get; set; }

        [JsonPropertyName("piercings_received")]
        public int PiercingsReceived { get; set; }

        [JsonPropertyName("piercings")]
        public int Piercings { get; set; }

        [JsonPropertyName("max_damage_tank_id")]
        public int? MaxDamageTankId { get; set; }

        [JsonPropertyName("xp")]
        public int XP { get; set; }

        [JsonPropertyName("survived_battles")]
        public int SurvivedBattles { get; set; }

        [JsonPropertyName("dropped_capture_points")]
        public int DroppedCapturePoints { get; set; }

        [JsonPropertyName("hits_percents")]
        public int HitsPercents { get; set; }

        [JsonPropertyName("draws")]
        public int Draws { get; set; }

        [JsonPropertyName("max_xp_tank_id")]
        public int? MaxXpTankId { get; set; }

        [JsonPropertyName("battles")]
        public int Battles { get; set; }

        [JsonPropertyName("damage_received")]
        public int DamageReceived { get; set; }

        [JsonPropertyName("avg_damage_assisted")]
        public float AvgDamageAssisted { get; set; }

        [JsonPropertyName("max_frags_tank_id")]
        public int? MaxFragsTankId { get; set; }

        [JsonPropertyName("avg_damage_assisted_track")]
        public float AvgDamageAssistedTrack { get; set; }

        [JsonPropertyName("frags")]
        public int Frags { get; set; }

        [JsonPropertyName("stun_number")]
        public int StunNumber { get; set; }

        [JsonPropertyName("avg_damage_assisted_radio")]
        public float AvgDamageAssistedRadio { get; set; }

        [JsonPropertyName("capture_points")]
        public int CapturePoints { get; set; }

        [JsonPropertyName("stun_assisted_damage")]
        public int StunAssistedDamage { get; set; }

        [JsonPropertyName("max_damage")]
        public int MaxDamage { get; set; }

        [JsonPropertyName("hits")]
        public int Hits { get; set; }

        [JsonPropertyName("battle_avg_xp")]
        public int BattleAvgXp { get; set; }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("losses")]
        public int Losses { get; set; }

        [JsonPropertyName("damage_dealt")]
        public int DamageDealt { get; set; }

        [JsonPropertyName("no_damage_direct_hits_received")]
        public int NoDamageDirectHitsReceived { get; set; }

        [JsonPropertyName("max_frags")]
        public int MaxFrags { get; set; }

        [JsonPropertyName("shots")]
        public int Shots { get; set; }

        [JsonPropertyName("explosion_hits_received")]
        public int ExplosionHitsReceived { get; set; }

        [JsonPropertyName("tanking_factor")]
        public float TankingFactor { get; set; }
    }
}
