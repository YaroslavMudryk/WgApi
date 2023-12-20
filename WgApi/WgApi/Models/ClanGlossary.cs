using System.Text.Json.Serialization;

namespace WgApi.Models
{
    public class ClansRoles
    {
        [JsonPropertyName("recruitment_officer")]
        public string RecruitmentOfficer { get; set; }

        [JsonPropertyName("personnel_officer")]
        public string PersonnelOfficer { get; set; }

        [JsonPropertyName("quartermaster")]
        public string Quartermaster { get; set; }

        [JsonPropertyName("executive_officer")]
        public string ExecutiveOfficer { get; set; }

        [JsonPropertyName("recruit")]
        public string Recruit { get; set; }

        [JsonPropertyName("private")]
        public string Private { get; set; }

        [JsonPropertyName("commander")]
        public string Commander { get; set; }

        [JsonPropertyName("reservist")]
        public string Reservist { get; set; }

        [JsonPropertyName("combat_officer")]
        public string CombatOfficer { get; set; }

        [JsonPropertyName("junior_officer")]
        public string JuniorOfficer { get; set; }

        [JsonPropertyName("intelligence_officer")]
        public string IntelligenceOfficer { get; set; }
    }
}
