using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class Frags
    {
        [JsonPropertyName("crucialShotMedal")]
        public int CrucialShotMedal { get; set; }

        [JsonPropertyName("prematureDetonationMedal")]
        public int PrematureDetonationMedal { get; set; }

        [JsonPropertyName("sentinelMedal")]
        public int SentinelMedal { get; set; }

        [JsonPropertyName("infiltratorMedal")]
        public int InfiltratorMedal { get; set; }

        [JsonPropertyName("fightingReconnaissanceMedal")]
        public int FightingReconnaissanceMedal { get; set; }

        [JsonPropertyName("fireAndSteelMedal")]
        public int FireAndSteelMedal { get; set; }

        [JsonPropertyName("rangerMedal")]
        public int RangerMedal { get; set; }

        [JsonPropertyName("reliableComrade")]
        public int ReliableComrade { get; set; }

        [JsonPropertyName("pyromaniacMedal")]
        public int PyromaniacMedal { get; set; }

        [JsonPropertyName("wolfAmongSheepMedal")]
        public int WolfAmongSheepMedal { get; set; }

        [JsonPropertyName("heavyFireMedal")]
        public int HeavyFireMedal { get; set; }

        [JsonPropertyName("bruteForceMedal")]
        public int BruteForceMedal { get; set; }

        [JsonPropertyName("guerrillaMedal")]
        public int GuerrillaMedal { get; set; }

        [JsonPropertyName("promisingFighterMedal")]
        public int PromisingFighterMedal { get; set; }

        [JsonPropertyName("beasthunter")]
        public int Beasthunter { get; set; }

        [JsonPropertyName("geniusForWarMedal")]
        public int GeniusForWarMedal { get; set; }

        [JsonPropertyName("sinai")]
        public int Sinai { get; set; }

        [JsonPropertyName("pattonValley")]
        public int PattonValley { get; set; }
    }
}
