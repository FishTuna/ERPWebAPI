using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingPlan:IEntity
    {
     [Key]
        public int TrainingId { get; set; }
        public string? TrainingName { get; set; }
        public short TrainingTypeId { get; set; }
        public string? TrainingType { get; set; }
        public string? ActivityIndicator { get; set; }
        public int AnticipatedParticipant { get; set; }
        public int TrainingDuration { get; set; }
        public byte MinSessionDuration { get; set; }
        public byte MaxSessionDuration { get; set; }
        public bool IsCertified { get; set; }
        public int TemplateCertificateId { get; set; }
        public bool IsRepeats { get; set; }
        public int RepetitionPeriod { get; set; }
        public byte DatePeriodTypeId { get; set; }
        public string? DatePeriodType { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
