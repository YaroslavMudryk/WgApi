using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class ClanReserves
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("bonus_type")]
        public string BonusType { get; set; }

        [JsonPropertyName("disposable")]
        public bool Disposable { get; set; }

        [JsonPropertyName("in_stock")]
        public InStock[] InStock { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
