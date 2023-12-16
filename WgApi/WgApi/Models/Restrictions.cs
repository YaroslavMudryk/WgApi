using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class Restrictions
    {
        [JsonPropertyName("chat_ban_time")]
        public object ChatBanTime { get; set; }
    }
}
