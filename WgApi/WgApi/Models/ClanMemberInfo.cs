using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class ClanMemberInfo
    {
        [JsonPropertyName("clan")]
        public ClanShortInfo Clan { get; set; }

        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }

        [JsonPropertyName("role_i18n")]
        public string RoleI18n { get; set; }

        [JsonPropertyName("joined_at")]
        public int JoinedAt { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }
    }

    public class ClanShortInfo
    {
        [JsonPropertyName("members_count")]
        public int MembersCount { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("created_at")]
        public int CreatedAt { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("emblems")]
        public Dictionary<string, Emblem> Emblems { get; set; }

        [JsonPropertyName("clan_id")]
        public int ClanId { get; set; }
    }
}
