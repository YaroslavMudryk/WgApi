using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;
using WgApi.Models.WotStatistics;

namespace WgApi.Models
{
    public class WotAccount
    {
        [JsonPropertyName("client_language")]
        public string ClientLanguage { get; set; }
        [JsonPropertyName("last_battle_time")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime LastBattleTime { get; set; }
        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }
        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("private")]
        public Private Private { get; set; }
        [JsonPropertyName("global_rating")]
        public int GlobalRating { get; set; }
        [JsonPropertyName("clan_id")]
        public int ClanId { get; set; }
        [JsonPropertyName("statistics")]
        public Statistics Statistics { get; set; }
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }
        [JsonPropertyName("logout_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime LogoutAt { get; set; }
    }
}
