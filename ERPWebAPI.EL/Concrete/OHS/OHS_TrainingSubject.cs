using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingSubject: IEntity
    {
        [Key]
        public int SubjectId { get; set; }
        public string? Subject { get; set; }
        public short TrainingTypeId { get; set; }
        public string? TrainingType { get; set; }
        public string? ActivityIndicator { get; set; }
        public bool IsCertificated { get; set; }
        public int TemplateCertificateId { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsRepeats { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
