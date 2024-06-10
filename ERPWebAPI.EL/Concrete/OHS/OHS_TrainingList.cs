
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingList:IEntity
    {
        [Key]
        public int OhsTrainingId { get; set; }
        public string OhsTrainingName { get; set; }
        public string TrainingType { get; set; }
        public string InstructorType { get; set; }
        public string InstructorSocialSecurityNumber { get; set; }
        public string InstructorName { get; set; }
        public string InstructorTitle { get; set; }
        public string TrainingComment { get; set; }
        public string TrainingLocation { get; set; }
        public string TrainingOrganizer { get; set; }
        public bool IsCertificated { get; set; }
        public int? TemplateCertificateId { get; set; }
        public string? TemplateCertificateName { get; set; }
        public DateTime TrainingBegining { get; set; }
        public DateTime TrainingEnding { get; set; }
        public byte TraningStatusId { get; set; }
        public string? TrainingStatus { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }

    }
}
