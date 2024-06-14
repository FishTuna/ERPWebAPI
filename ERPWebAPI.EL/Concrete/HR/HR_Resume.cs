using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_Resume : IEntity
    {
        [Key]
        public int ResumeId { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public string Name { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Age { get; set; }
        public byte GraduationTypeId { get; set; }
        public string? GraduationType { get; set; }
        public string Profession { get; set; }
        public string? Reference { get; set; }
        public string? ResumePath { get; set; }
        public byte DisabilityPercent { get; set; }
        public string? DisabilityDescription { get; set; }
        public byte HiringProcessStatusId { get; set; }
        public string? HiringProcessStatus { get; set; }
        public string? HiringProcessStatusComment { get; set; }
        public int MeetingsCount { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
