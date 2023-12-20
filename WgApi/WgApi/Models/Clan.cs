using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;

namespace WgApi.Models
{
    public class Clan
    {
        [JsonPropertyName("leader_id")]
        public int LeaderId { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("updated_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("private")]
        public ClanPrivate Private { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("members_count")]
        public int MembersCount { get; set; }

        [JsonPropertyName("description_html")]
        public string DescriptionHtml { get; set; }

        [JsonPropertyName("creator_id")]
        public int CreatorId { get; set; }

        [JsonPropertyName("leader_name")]
        public string LeaderName { get; set; }

        [JsonPropertyName("emblems")]
        public Dictionary<string, Emblem> Emblems { get; set; }

        [JsonPropertyName("clan_id")]
        public int ClanId { get; set; }

        [JsonPropertyName("renamed_at")]
        public int RenamedAt { get; set; }

        [JsonPropertyName("old_tag")]
        public string OldTag { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("members")]
        public Dictionary<string, ClanMember> Members { get; set; }

        [JsonPropertyName("old_name")]
        public string OldName { get; set; }

        [JsonPropertyName("is_clan_disbanded")]
        public bool IsClanDisbanded { get; set; }

        [JsonPropertyName("motto")]
        public string Motto { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("creator_name")]
        public string CreatorName { get; set; }

        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("accepts_join_requests")]
        public bool AcceptsJoinRequests { get; set; }
    }
}
