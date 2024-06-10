

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_PersonWorkMonitoringList : IEntity
    {
        [Key]
        public int WorkMonitoringId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int OhsCompanyId { get; set; }
        public string? OhsCompanyName { get; set; }
        public string Facility { get; set; }
        public byte SocialSecurityTypeId { get; set; }
        public string SocialSecurityType { get; set; }
        public byte OhsDangerClassId { get; set; }
        public string? DangerClass { get; set; }
        public int NACECodeId { get; set; }
        public string? NACECode { get; set; }
        public int OhsJobId { get; set; }
        public string? OhsJob { get; set; }
        public string? Comment { get; set; }
        public DateTime InformingDate { get; set; }
        public DateTime? ExpirationOfInforming { get; }
        public byte InformingControlState { get; set; }
        public DateTime HealthReportDate { get; set; }
        public DateTime? ExpirationOfHealthReport { get; set; }
        public byte HealthReportControlState { get; set; }
        public DateTime OhsCertificateDate { get; set; }
        public DateTime? ExpirationOfOhsCertificateDate { get; set; }
        public byte OhsCertificateControlState { get; set; }
        public DateTime AssignmentLetterDate { get; set; }
        public DateTime? ExpirationOfAssignmentLetter { get; set; }
        public byte AssignmentLetterControlState { get; set; }
        public byte? StatusId { get; set; }
        public string? StatusName { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
