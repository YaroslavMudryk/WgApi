using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;

namespace WgApi.Models
{
    public class Private
    {
        [JsonPropertyName("restrictions")]
        public Restrictions Restrictions { get; set; }
        [JsonPropertyName("gold")]
        public int Gold { get; set; }
        [JsonPropertyName("free_xp")]
        public int FreeXP { get; set; }
        [JsonPropertyName("ban_time")]
        public object BanTime { get; set; }
        [JsonPropertyName("is_bound_to_phone")]
        public bool IsBoundToPhone { get; set; }
        [JsonPropertyName("is_premium")]
        public bool IsPremium { get; set; }
        [JsonPropertyName("credits")]
        public int Credits { get; set; }
        [JsonPropertyName("premium_expires_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime PremiumExpiresAt { get; set; }
        [JsonPropertyName("bonds")]
        public int Bonds { get; set; }
        [JsonPropertyName("battle_life_time")]
        public int BattleLifeTimeInSeconds { get; set; }
        [JsonPropertyName("ban_info")]
        public object BanInfo { get; set; }
    }
}
