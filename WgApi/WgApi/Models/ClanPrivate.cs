using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class ClanPrivate
    {
        [JsonPropertyName("clan_treasury")]
        public ClanTreasury ClanTreasury { get; set; }

        [JsonPropertyName("online_members")]
        public int[] OnlineMembers { get; set; }

        [JsonPropertyName("treasury")]
        public int Treasury { get; set; }
    }
}
