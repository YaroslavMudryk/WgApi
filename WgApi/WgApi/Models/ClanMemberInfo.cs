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
}
