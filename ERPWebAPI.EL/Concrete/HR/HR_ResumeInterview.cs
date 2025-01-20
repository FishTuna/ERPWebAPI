using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_ResumeInterview :IEntity
    {
        [Key]
        public int ResumeInterviewId { get; set; }
        public int ResumeId { get; set; }
        public string? NameLastname { get; set; }
        public string? ContactInfo { get; set; }
        public DateTime InterviewDate { get; set; }
        public string? GraduationType { get; set; }
        public string? Profession { get; set; }
        public string? Comment { get; set; }
        public bool IsActive { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }

    }
}
