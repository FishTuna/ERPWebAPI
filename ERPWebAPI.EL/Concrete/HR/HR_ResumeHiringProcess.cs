using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_ResumeHiringProcess : IEntity
    {
        [Key]
        public int ResumeHiringProcessId { get; set; }
        public int ResumeId { get; set; }
        public int? InterviewerUserEmployeeId { get; set; }
        public string? Interviewer { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string? HrComment { get; set; }
        public short FacilityId { get; set; }
        public string? FacilityName { get; set; }
        public string? FacilitySupervisor { get; set; }
        public int FacilitySupervisorId { get; set; }
        public string? FacilityComment { get; set; }
        public short DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentSupervisor { get; set; }
        public int DepartmentSupervisorId { get; set; }
        public string? DepartmentComment { get; set; }
        public short PositionId { get; set; }
        public string? PositionName { get; set; }
        public short JobId { get; set; }
        public string? JobName { get; set; }
        public string? SystemRecommendation { get; set; }
        public bool AcceptsOtherPositions { get; set; }
        public byte HiringProcessStatusId { get; set; }
        public string? HiringProcessStatus { get; set; }
        public string? HiringProcessStatusComment { get; set; }
        public byte? HiringProcessResultId { get; set; }
        public string? HiringProcessResult { get; set; }
        
    }
}
