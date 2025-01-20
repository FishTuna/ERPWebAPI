using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingCertificate : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? CertificateName { get; set; }
        public string? CertificatePath { get; set; }
        public bool IsActive { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
