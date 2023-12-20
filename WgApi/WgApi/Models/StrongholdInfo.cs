using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class StrongholdInfo
    {
        [JsonPropertyName("command_center_arena_id")]
        public string CommandCenterArenaId { get; set; }

        [JsonPropertyName("stronghold_buildings_level")]
        public int StrongholdBuildingsLevel { get; set; }

        [JsonPropertyName("skirmish_statistics")]
        public SkirmishStatistics SkirmishStatistics { get; set; }

        [JsonPropertyName("battles_series_for_strongholds_statistics")]
        public BattlesSeriesForStrongholdsStatistics BattlesSeriesForStrongholdsStatistics { get; set; }

        [JsonPropertyName("clan_name")]
        public string ClanName { get; set; }

        [JsonPropertyName("stronghold_level")]
        public int StrongholdLevel { get; set; }

        [JsonPropertyName("clan_id")]
        public int ClanId { get; set; }

        [JsonPropertyName("battles_for_strongholds_statistics")]
        public BattlesForStrongholdsStatistics BattlesForStrongholdsStatistics { get; set; }

        [JsonPropertyName("building_slots")]
        public BuildingSlots[] BuildingSlots { get; set; }

        [JsonPropertyName("clan_tag")]
        public string ClanTag { get; set; }
    }
}
