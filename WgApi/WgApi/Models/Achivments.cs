using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class Achievement
    {
        [JsonPropertyName("achievements")]
        public Achievements Achievements { get; set; }
        [JsonPropertyName("frags")]
        public Frags Frags { get; set; }
        [JsonPropertyName("max_series")]
        public MaxSeries MaxSeries { get; set; }
    }
}
