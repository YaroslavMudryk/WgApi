using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;

namespace WgApi.Models
{
    public class PrivateInfo
    {
        [JsonPropertyName("premium_expires_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? PremiumExpiresAt { get; set; }
        [JsonPropertyName("free_xp")]
        public int FreeXP { get; set; }
        [JsonPropertyName("gold")]
        public int Gold { get; set; }
    }
}
