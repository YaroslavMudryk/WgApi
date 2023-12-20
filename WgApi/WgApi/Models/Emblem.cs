using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class Emblem
    {
        [JsonPropertyName("portal")]
        public string Portal { get; set; }

        [JsonPropertyName("wowp")]
        public string Wowp { get; set; }

        [JsonPropertyName("wot")]
        public string Wot { get; set; }
    }
}
