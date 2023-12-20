using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;

namespace WgApi.Models
{
    public class ClanInfo
    {
        [JsonPropertyName("members_count")]
        public int MembersCount { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("emblems")]
        public Dictionary<string, Emblem> Emblems { get; set; }

        [JsonPropertyName("clan_id")]
        public int ClanId { get; set; }
    }

    public class Emblem
    {
        [JsonPropertyName("portal")]
        public string Portal { get; set; }

        [JsonPropertyName("wowp")]
        public string Wowp { get; set; }

        [JsonPropertyName("wot")]
        public string Wot { get; set; }
    }
}
