using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_SchoolDepartment : IEntity
    {

        [Key]
        public int SchoolDepartmentId { get; set; }
        public bool IsActive { get; set; }
        public string? SchoolDepartment { get; set; }
        public byte SchoolTypeId { get; set; }
        public string? SchoolType { get; set; }
        public byte GraduationTypeId { get; set; }
        public string GraduationType { get; set; }
        public int DepartmentCode { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
