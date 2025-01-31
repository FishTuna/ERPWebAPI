using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingPlan:IEntity
    {
        [Key]
        public int PlanId { get; set; }
        public byte PeriodYearId { get; set; }
        public int PeriodYear { get; set; }
        public int OhsSubjectId { get; set; }
        public string? OhsSubject { get; set; }
        public string? TrainingName { get; set; }
        public short TrainingTypeId { get; set; }
        public string? TrainingType { get; set; }
        public string? ActivityIndicator { get; set; }
        public string? ResponsiblePositions { get; set; }
        public int AnticipatedParticipant { get; set; }
        public int ActualParticipant { get; set; }
        public int TrainingDurationByMinute { get; set; }
        public double TrainingDuration { get; set; }
        public double CompletedDuration { get; set; }
        public byte DatePeriodTypeId { get; set; }
        public string? DatePeriodType { get; set; }
        public DateTime? EstimatedPlanDate { get; set; }
        public string? TrainingOfficer { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
