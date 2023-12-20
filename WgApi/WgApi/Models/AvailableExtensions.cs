using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class AvailableExtensions
    {
        [JsonPropertyName("wage")]
        public int Wage { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description_tactical")]
        public object DescriptionTactical { get; set; }

        [JsonPropertyName("cost")]
        public int Cost { get; set; }

        [JsonPropertyName("description_strategic")]
        public string DescriptionStrategic { get; set; }

        [JsonPropertyName("extension_id")]
        public string ExtensionId { get; set; }
    }
}
