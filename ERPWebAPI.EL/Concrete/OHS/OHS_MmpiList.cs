

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_MmpiList : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string SocialSecurityNo { get; set; }
        public short FaciiltyId { get; set; }
        public string? Faclity { get; set; }
        public short DepartmentId { get; set; }
        public string? Department { get; set; }
        public string NameLastName { get; set; }
        public byte GenderId { get; set; }
        public string? Gender { get; set; }
        public DateTime MmpiDate { get; set; }
        public short TestReasonId { get; set; }
        public string? TestReason { get; set; }
        public string? Comment { get; set; }
        public int SupervisorEmployeeId { get; set; }
        public string Supervisor { get; set; }
        public bool IsMarked { get; set; }
        public bool Repeat { get; set; }
        public short? RepeatUnitTypeId { get; set; }
        public string? RepeatUnitType { get; set; }
        public int? RepeatPeriod { get; set; }
        public bool? IsEvaluated { get; set; }
        public string? EvaluationResult { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }

    }
}
