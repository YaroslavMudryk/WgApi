using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class MaxSeries
    {
        [JsonPropertyName("deathTrack")]
        public int DeathTrack { get; set; }

        [JsonPropertyName("aimer")]
        public int Aimer { get; set; }

        [JsonPropertyName("titleSniper")]
        public int TitleSniper { get; set; }

        [JsonPropertyName("armorPiercer")]
        public int ArmorPiercer { get; set; }

        [JsonPropertyName("invincible")]
        public int Invincible { get; set; }

        [JsonPropertyName("tacticalBreakthrough")]
        public int TacticalBreakthrough { get; set; }

        [JsonPropertyName("EFC2016")]
        public int EFC2016 { get; set; }

        [JsonPropertyName("victoryMarch")]
        public int VictoryMarch { get; set; }

        [JsonPropertyName("diehard")]
        public int Diehard { get; set; }

        [JsonPropertyName("WFC2014")]
        public int WFC2014 { get; set; }

        [JsonPropertyName("handOfDeath")]
        public int HandOfDeath { get; set; }
    }
}
