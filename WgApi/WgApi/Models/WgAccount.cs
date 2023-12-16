using System.Text.Json.Serialization;
using WgApi.Helpers.Converters;

namespace WgApi.Models
{
    public class WgAccount
    {
        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }
        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(UnixEpochTimeToDateTimeJsonConverter))]
        public DateTime? CreatedAt { get; set; }
        [JsonPropertyName("games")]
        public string[] Games { get; set; }
        [JsonPropertyName("private")]
        public PrivateInfo Info { get; set; }
    }
}
