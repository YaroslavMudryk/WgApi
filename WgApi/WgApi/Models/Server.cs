using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class Server
    {
        [JsonPropertyName("server")]
        public int Name { get; set; }
        [JsonPropertyName("players_online")]
        public int? PlayersOnline { get; set; }
    }
}
