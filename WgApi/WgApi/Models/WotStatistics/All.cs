using System.Text.Json.Serialization;

namespace WgApi.Models.WotStatistics
{
    public class All : BaseStats
    {
        [JsonPropertyName("max_frags")]
        public int MaxGrags { get; set; }
    }
}
