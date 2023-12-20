using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class GlobalFrontMap
    {
        [JsonPropertyName("front_name")]
        public string FrontName { get; set; }

        [JsonPropertyName("max_tanks_per_division")]
        public int MaxTanksPerDivision { get; set; }

        [JsonPropertyName("fog_of_war")]
        public bool FogOfWar { get; set; }

        [JsonPropertyName("division_cost")]
        public int DivisionCost { get; set; }

        [JsonPropertyName("min_vehicle_level")]
        public int MinVehicleLevel { get; set; }

        [JsonPropertyName("avg_clans_rating")]
        public int AvgClansRating { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("vehicle_freeze")]
        public bool VehicleFreeze { get; set; }

        [JsonPropertyName("avg_won_bet")]
        public int AvgWonBet { get; set; }

        [JsonPropertyName("provinces_count")]
        public int ProvincesCount { get; set; }

        [JsonPropertyName("available_extensions")]
        public AvailableExtensions[] AvailableExtensions { get; set; }

        [JsonPropertyName("max_vehicle_level")]
        public int MaxVehicleLevel { get; set; }

        [JsonPropertyName("min_tanks_per_division")]
        public int MinTanksPerDivision { get; set; }

        [JsonPropertyName("battle_time_limit")]
        public int BattleTimeLimit { get; set; }

        [JsonPropertyName("is_event")]
        public bool IsEvent { get; set; }

        [JsonPropertyName("avg_min_bet")]
        public int AvgMinBet { get; set; }

        [JsonPropertyName("front_id")]
        public string FrontId { get; set; }
    }
}
