using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class ClanTreasury
    {
        [JsonPropertyName("credits")]
        public object Credits { get; set; }

        [JsonPropertyName("gold")]
        public int Gold { get; set; }

        [JsonPropertyName("crystal")]
        public int Crystal { get; set; }
    }
}
