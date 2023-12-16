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

    public class Achievements
    {
        [JsonPropertyName("medalCarius")]
        public int MedalCarius { get; set; }

        [JsonPropertyName("NY20A2")]
        public int NY20A2 { get; set; }

        [JsonPropertyName("NY20A3")]
        public int NY20A3 { get; set; }

        [JsonPropertyName("medalFadin")]
        public int MedalFadin { get; set; }

        [JsonPropertyName("armorPiercer")]
        public int ArmorPiercer { get; set; }

        [JsonPropertyName("medalEkins")]
        public int MedalEkins { get; set; }

        [JsonPropertyName("defender")]
        public int Defender { get; set; }

        [JsonPropertyName("medalBobLebwa")]
        public int MedalBobLebwa { get; set; }

        [JsonPropertyName("wt2022HunterWins")]
        public int Wt2022HunterWins { get; set; }

        [JsonPropertyName("supporter")]
        public int Supporter { get; set; }

        [JsonPropertyName("medalLehvaslaiho")]
        public int MedalLehvaslaiho { get; set; }

        [JsonPropertyName("medalPascucci")]
        public int MedalPascucci { get; set; }

        [JsonPropertyName("NY18A1")]
        public int NY18A1 { get; set; }

        [JsonPropertyName("se2020Medal")]
        public int Se2020Medal { get; set; }

        [JsonPropertyName("NY18A2")]
        public int NY18A2 { get; set; }

        [JsonPropertyName("titleSniper")]
        public int TitleSniper { get; set; }

        [JsonPropertyName("medalCrucialContribution")]
        public int MedalCrucialContribution { get; set; }

        [JsonPropertyName("TenYearsCountdownSPGEventMedal")]
        public int TenYearsCountdownSPGEventMedal { get; set; }

        [JsonPropertyName("arsonist")]
        public int Arsonist { get; set; }

        [JsonPropertyName("scout")]
        public int Scout { get; set; }

        [JsonPropertyName("fallout")]
        public int Fallout { get; set; }

        [JsonPropertyName("bootcampMedal")]
        public int BootcampMedal { get; set; }

        [JsonPropertyName("tankExpert2")]
        public int TankExpert2 { get; set; }

        [JsonPropertyName("tankExpert1")]
        public int TankExpert1 { get; set; }

        [JsonPropertyName("tankExpert7")]
        public int TankExpert7 { get; set; }

        [JsonPropertyName("tankExpert6")]
        public int TankExpert6 { get; set; }

        [JsonPropertyName("tankExpert5")]
        public int TankExpert5 { get; set; }

        [JsonPropertyName("tankExpert4")]
        public int TankExpert4 { get; set; }

        [JsonPropertyName("medalLavrinenko")]
        public int MedalLavrinenko { get; set; }

        [JsonPropertyName("medalKolobanov")]
        public int MedalKolobanov { get; set; }

        [JsonPropertyName("medalLafayettePool")]
        public int MedalLafayettePool { get; set; }

        [JsonPropertyName("medalKnispel")]
        public int MedalKnispel { get; set; }

        [JsonPropertyName("shootToKill")]
        public int ShootToKill { get; set; }

        [JsonPropertyName("invader")]
        public int Invader { get; set; }

        [JsonPropertyName("bonecrusher")]
        public int Bonecrusher { get; set; }

        [JsonPropertyName("medalKay")]
        public int MedalKay { get; set; }

        [JsonPropertyName("duelist")]
        public int Duelist { get; set; }

        [JsonPropertyName("even")]
        public int Even { get; set; }

        [JsonPropertyName("medalBrothersInArms")]
        public int MedalBrothersInArms { get; set; }

        [JsonPropertyName("medalAbrams")]
        public int MedalAbrams { get; set; }

        [JsonPropertyName("medalRotmistrov")]
        public int MedalRotmistrov { get; set; }

        [JsonPropertyName("tankwomen")]
        public int Tankwomen { get; set; }

        [JsonPropertyName("luckyDevil")]
        public int LuckyDevil { get; set; }

        [JsonPropertyName("mainGun")]
        public int MainGun { get; set; }

        [JsonPropertyName("ironMan")]
        public int IronMan { get; set; }

        [JsonPropertyName("TenYearsCountdownParticipation")]
        public int TenYearsCountdownParticipation { get; set; }

        [JsonPropertyName("BattlePassCommonPr_9")]
        public int BattlePassCommonPr_9 { get; set; }

        [JsonPropertyName("warrior")]
        public int Warrior { get; set; }

        [JsonPropertyName("medalDumitru")]
        public int MedalDumitru { get; set; }

        [JsonPropertyName("NY23_CelebChallenge")]
        public int NY23_CelebChallenge { get; set; }

        [JsonPropertyName("readyForBattleMT")]
        public int ReadyForBattleMT { get; set; }

        [JsonPropertyName("FE18Collection1")]
        public int FE18Collection1 { get; set; }

        [JsonPropertyName("medalBillotte")]
        public int MedalBillotte { get; set; }

        [JsonPropertyName("impenetrable")]
        public int Impenetrable { get; set; }

        [JsonPropertyName("evileye")]
        public int Evileye { get; set; }

        [JsonPropertyName("medalHalonen")]
        public int MedalHalonen { get; set; }

        [JsonPropertyName("aimer")]
        public int Aimer { get; set; }

        [JsonPropertyName("_05YearsOfService")]
        public int _05YearsOfService { get; set; }

        [JsonPropertyName("_09YearsOfService")]
        public int _09YearsOfService { get; set; }

        [JsonPropertyName("readyForBattleHT")]
        public int ReadyForBattleHT { get; set; }

        [JsonPropertyName("hw2023Medal")]
        public int Hw2023Medal { get; set; }

        [JsonPropertyName("medalRadleyWalters")]
        public int MedalRadleyWalters { get; set; }

        [JsonPropertyName("BattlePassCommonPr_NY23")]
        public int BattlePassCommonPr_NY23 { get; set; }

        [JsonPropertyName("steelwall")]
        public int Steelwall { get; set; }

        [JsonPropertyName("medalPoppel")]
        public int MedalPoppel { get; set; }

        [JsonPropertyName("EFC2016")]
        public int EFC2016 { get; set; }

        [JsonPropertyName("sniper2")]
        public int Sniper2 { get; set; }

        [JsonPropertyName("kamikaze")]
        public int Kamikaze { get; set; }

        [JsonPropertyName("sinai")]
        public int Sinai { get; set; }

        [JsonPropertyName("TenYearsCountdownStageMedal")]
        public int TenYearsCountdownStageMedal { get; set; }

        [JsonPropertyName("firstMerit")]
        public int FirstMerit { get; set; }

        [JsonPropertyName("xmasTreeBronze")]
        public int XmasTreeBronze { get; set; }

        [JsonPropertyName("_06YearsOfService")]
        public int _06YearsOfService { get; set; }

        [JsonPropertyName("NY24_AtmsphrLevel")]
        public int NY24_AtmsphrLevel { get; set; }

        [JsonPropertyName("beasthunter")]
        public int Beasthunter { get; set; }

        [JsonPropertyName("charmed")]
        public int Charmed { get; set; }

        [JsonPropertyName("conqueror")]
        public int Conqueror { get; set; }

        [JsonPropertyName("mousebane")]
        public int Mousebane { get; set; }

        [JsonPropertyName("newMeritPM2")]
        public int NewMeritPM2 { get; set; }

        [JsonPropertyName("readyForBattleATSPG")]
        public int ReadyForBattleATSPG { get; set; }

        [JsonPropertyName("medalLeClerc")]
        public int MedalLeClerc { get; set; }

        [JsonPropertyName("demolition")]
        public int Demolition { get; set; }

        [JsonPropertyName("wtxHunterWins")]
        public int WtxHunterWins { get; set; }

        [JsonPropertyName("operationWinter")]
        public int OperationWinter { get; set; }

        [JsonPropertyName("reliableComrade")]
        public int ReliableComrade { get; set; }

        [JsonPropertyName("NY19A1")]
        public int NY19A1 { get; set; }

        [JsonPropertyName("NY19A2")]
        public int NY19A2 { get; set; }

        [JsonPropertyName("NY19A3")]
        public int NY19A3 { get; set; }

        [JsonPropertyName("handOfDeath")]
        public int HandOfDeath { get; set; }

        [JsonPropertyName("medalOrlik")]
        public int MedalOrlik { get; set; }
        [JsonPropertyName("huntsman")]
        public int Huntsman { get; set; }
        [JsonPropertyName("NY20A1")]
        public int NY20A1 { get; set; }
        [JsonPropertyName("FE18Universal")]
        public int FE18Universal { get; set; }
        [JsonPropertyName("NY23_AtmsphrLevel")]
        public int NY23AtmsphrLevel { get; set; }
        [JsonPropertyName("NY22_AtmsphrLevel")]
        public int NY22AtmsphrLevel { get; set; }
        [JsonPropertyName("falloutSteelHunter")]
        public int FalloutSteelHunter { get; set; }
        [JsonPropertyName("fighter")]
        public int Fighter { get; set; }
        [JsonPropertyName("sturdy")]
        public int Sturdy { get; set; }
        [JsonPropertyName("soldierOfFortune")]
        public int SoldierOfFortune { get; set; }
        [JsonPropertyName("07YearsOfService")]
        public int _07YearsOfService { get; set; }
        [JsonPropertyName("xmasTreeSilver")]
        public int XmasTreeSilver { get; set; }
        [JsonPropertyName("04YearsOfService")]
        public int _04YearsOfService { get; set; }
        [JsonPropertyName("08YearsOfService")]
        public int _08YearsOfService { get; set; }
    }

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
