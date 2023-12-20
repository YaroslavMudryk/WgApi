using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;

namespace WgApi.Models
{
    public class ClanMember
    {
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("role_i18n")]
        public string RoleI18n { get; set; }

        [JsonPropertyName("joined_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? JoinedAt { get; set; }

        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }
    }
}
