using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_Employee : IEntity

    {
        [Key]
        public int EmployeeId { get; set; }
        public string? SocialSecurityno { get; set; }
        public string? RegistryNo { get; set; } 
        public string? Name { get; set; }
        public string? SecondName { get; set; } 
        public string? LastName { get; set; }
        public string? SecondLastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PlaceOfBirth { get; set; } 
        public string? MothersName { get; set; } 
        public string? FathersName { get; set; } 
        public byte MaritalStatusId { get; set; } 
        public string? MaritalStatus { get; set; }
        public byte BloodTypeId { get; set; }
        public string? BloodType { get; set; }
        public byte MilitaryServiceStatusId { get; set; }
        public string? MilitaryServiceStatus { get; set; }
        public short CompanyId { get; set; }
        public string? Company {  get; set; }
        public short FacilityId { get; set; }
        public string? Facility { get; set; }
        public short CostCenterId { get; set; }
        public string? CostCenter { get; set; }
        public short DepartmentId { get; set; }
        public string? Department { get; set; }
        public short JobId { get; set; }
        public string? Job { get; set; }
        public short PositionId { get; set; }
        public string? Position { get; set; }
        public byte CollarId { get; set; }
        public string? Collar { get; set; }
        public byte LeaveEarningTypeId { get; set; }
        public string? LeaveEarningType { get; set; }
        public bool IsTemporary { get; set; }
        public bool IsRetired { get; set; }
        public bool IsConvicted { get; set; }
        public bool IsActive { get; set; }
        public DateTime TransactionDate { get; set; }
        public string UserEmployee { get; set; }
    }
}
