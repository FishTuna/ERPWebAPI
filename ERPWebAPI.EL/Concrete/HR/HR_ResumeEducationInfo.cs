using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_ResumeEducationInfo : IEntity
    {
        [Key]
        public int ResumeEducationId { get; set; }
        public int ResumeId { get; set; }
        public string? SchoolCountry { get; set; }
        public string? SchoolCity { get; set; }
        public byte SchoolTypeId { get; set; }
        public string? SchoolType { get; set; }
        public byte GraduationTypeId { get; set; }
        public string? GraduationType { get; set; }
        public int SchoolId { get; set; }
        public string? SchoolName { get; set; }
        public byte EducationStatusId { get; set; }
        public string? EducationStatus { get; set; }
        public int SchoolDepartmentId { get; set; }
        public string? SchoolDepartment { get; set; }
        public DateTime? GraduationDate { get; set; }
        public string? DocumentPath { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? UserEmployee { get; set; }
    }
}
