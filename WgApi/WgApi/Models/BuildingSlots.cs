using System.Text.Json.Serialization;

namespace WgApi.Models
{
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
