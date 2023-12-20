using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class TankDetailStatistic
    {
        [JsonPropertyName("wins")]
        public int Wins { get; set; }
        [JsonPropertyName("battles")]
        public int Battles { get; set; }
    }
}
