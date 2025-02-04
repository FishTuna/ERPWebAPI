using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_EmployeeOrientationList : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? NameLastName { get; set; }
        public DateTime? EmploymentdDate { get; set; }
        public short FacilityId { get; set; }
        public string? Facility { get; set; }
        public short DepartmentId { get; set; }
        public string? Department { get; set; }
        public short PositionId { get; set; }
        public string? Position { get; set; }
        public short JobId { get; set; }
        public string? JobName { get; set; }
        public bool IsPlanned { get; set; }
        public int PlanId { get; set; }
        public DateTime? PlanDate { get; set; }
        public short ReasonId { get; set; }
        public string? Reason { get; set; }
        public DateTime? OrientationDate { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
