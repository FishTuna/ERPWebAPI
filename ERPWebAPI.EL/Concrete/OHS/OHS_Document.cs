using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_Document : IEntity
    {
        [Key]
        public int DocumentId { get; set; }
        public byte OhsMonitoringType { get; set; }
        public int OhsMonitoringId { get; set; }
        public string? DocumentComment { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string? OhsDocumentType { get; set; }
        public DateTime StartOfValidity { get; set; }
        public DateTime? EndOfValidity { get; set; }
        public string DocumentPath { get; set; }
        public bool IsActive { get; set; }
        public string UserEmployee { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
