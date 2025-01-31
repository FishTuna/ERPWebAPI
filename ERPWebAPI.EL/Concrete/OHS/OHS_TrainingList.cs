using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingList:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int OhsSubjectId { get; set; }
        public string? OhsSubject { get; set; }
        public string? TrainingComment { get; set; }
        public int TrainingOrganizerId { get; set; }
        public string? TrainingOrganizer { get; set; }
        public short TrainingTypeId { get; set; }
        public string? TrainingType { get; set; }
        public bool IsCertificated { get; set; }
        public DateTime TrainingBegining { get; set; }
        public DateTime TrainingEnding { get; set; }
        public short TrainingDuration { get; set; }
        public byte DatePeriodTypeId { get; set; }
        public string? DatePeriodType { get; set; }
        public bool IsOnline { get; set; }
        public bool IsAtOutSideLocation { get; set; }
        public string? TrainingLocation { get; set; }
        public string? Method { get; set; }
        public string? Regulation { get; set; }
        public byte TraningStatusId { get; set; }
        public string? TrainingStatus { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }


    }
}
