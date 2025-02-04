using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_EducationInfo : IEntity
    {
        [Key]
            public int EducationId { get; set; }
            public int EmployeeId { get; set; }
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
            public string? SchoolNameCountryCity { get; set; }
            public string? SchoolCountryCity { get; set; }
            public DateTime? GraduationDate { get; set; }
            public int DocumentId { get; set; }
            public string? DocumentPath { get; set; }
            public short SchoolCountryId { get; set; }
            public string? SchoolCountryName { get; set; }
            public int SchoolCityId { get; set; }
            public string? SchoolCityName { get; set; }
            public DateTime? TransactionDate { get; set; }
            public string? UserEmployee { get; set; }
        }
    }

