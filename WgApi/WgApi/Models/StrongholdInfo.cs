﻿using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;

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

    public class SkirmishStatistics
    {
        [JsonPropertyName("win_10")]
        public int Win10 { get; set; }

        [JsonPropertyName("total_6")]
        public int Total6 { get; set; }

        [JsonPropertyName("total_10")]
        public int Total10 { get; set; }

        [JsonPropertyName("win_6")]
        public int Win6 { get; set; }

        [JsonPropertyName("total_10_in_28d")]
        public int Total10In28D { get; set; }

        [JsonPropertyName("win_8_in_28d")]
        public int Win8In28D { get; set; }

        [JsonPropertyName("lose_8")]
        public int Lose8 { get; set; }

        [JsonPropertyName("lose_6")]
        public int Lose6 { get; set; }

        [JsonPropertyName("total_8")]
        public int Total8 { get; set; }

        [JsonPropertyName("last_time_6")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? LastTime6 { get; set; }

        [JsonPropertyName("last_time_10")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? LastTime10 { get; set; }

        [JsonPropertyName("lose_10")]
        public int Lose10 { get; set; }

        [JsonPropertyName("total_6_in_28d")]
        public int Total6In28D { get; set; }

        [JsonPropertyName("total_8_in_28d")]
        public int Total8In28D { get; set; }

        [JsonPropertyName("win_6_in_28d")]
        public int Win6In28D { get; set; }

        [JsonPropertyName("win_10_in_28d")]
        public int Win10In28D { get; set; }

        [JsonPropertyName("last_time_8")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? LastTime8 { get; set; }

        [JsonPropertyName("win_8")]
        public int Win8 { get; set; }
    }

    public class BattlesSeriesForStrongholdsStatistics
    {
        [JsonPropertyName("win_10")]
        public int Win10 { get; set; }

        [JsonPropertyName("total_10")]
        public int Total10 { get; set; }

        [JsonPropertyName("total_10_in_28d")]
        public int Total10In28D { get; set; }

        [JsonPropertyName("win_10_in_28d")]
        public int Win10In28D { get; set; }

        [JsonPropertyName("lose_10")]
        public int Lose10 { get; set; }
    }

    public class BattlesForStrongholdsStatistics
    {
        [JsonPropertyName("win_10")]
        public int Win10 { get; set; }

        [JsonPropertyName("total_10")]
        public int Total10 { get; set; }

        [JsonPropertyName("total_10_in_28d")]
        public int Total10In28D { get; set; }

        [JsonPropertyName("win_10_in_28d")]
        public int Win10In28D { get; set; }

        [JsonPropertyName("last_time_10")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? LastTime10 { get; set; }

        [JsonPropertyName("lose_10")]
        public int Lose10 { get; set; }
    }

    public class BuildingSlots
    {
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        [JsonPropertyName("arena_id")]
        public string ArenaId { get; set; }

        [JsonPropertyName("reserve_title")]
        public string ReserveTitle { get; set; }

        [JsonPropertyName("building_level")]
        public int BuildingLevel { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("building_title")]
        public string BuildingTitle { get; set; }
    }
}
