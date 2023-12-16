using System.Text.Json.Serialization;
using WgApi.Models.WotStatistics;

namespace WgApi.Models
{
    public class Statistics
    {
        [JsonPropertyName("clan")]
        public Clan Clan { get; set; }
        [JsonPropertyName("all")]
        public All All { get; set; }
        [JsonPropertyName("regular_team")]
        public RegularTeam RegularTeam { get; set; }
        [JsonPropertyName("trees_cut")]
        public int TreesCut { get; set; }
        [JsonPropertyName("company")]
        public Company Company { get; set; }
        [JsonPropertyName("stronghold_skirmish")]
        public StrongholdSkirmish StrongholdSkirmish { get; set; }
        [JsonPropertyName("stronghold_defense")]
        public StrongholdDefense StrongholdDefense { get; set; }
        [JsonPropertyName("historical")]
        public Historical Historical { get; set; }
        [JsonPropertyName("team")]
        public Team Team { get; set; }
        [JsonPropertyName("frags")]
        public Dictionary<string, int> Frags { get; set; }
    }
}
