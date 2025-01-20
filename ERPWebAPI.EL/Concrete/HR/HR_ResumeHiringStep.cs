using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_ResumeHiringStep:IEntity
    {
        [Key]
        public int StepId { get; set; }
        public int ProcessId { get; set; }
        public DateTime PlanDate { get; set; }
        public DateTime CommentDate { get; set; }
        public int SupervisorEmployeeId { get; set; }
        public string? Supervisor {  get; set; }
        public bool IsSuitable { get; set; }
        public string? Comment { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }

    }
}
