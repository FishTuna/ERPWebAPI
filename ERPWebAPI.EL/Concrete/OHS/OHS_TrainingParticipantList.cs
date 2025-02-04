using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingParticipantList : IEntity
    {
        [Key]
        public Int64 Id { get; set; }
        public int TrainingListId { get; set; }
        public int SessionId { get; set; }
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeLastName { get; set; }
        public DateTime? SessionDate { get; set; }
        public string? EmployeeFacility { get; set; }
        public string? EmployeeDepartment { get; set; }
        public string? EmployeePosition { get; set; }
        public string? EmployeeJob { get; set; }
        public int InvolvedById { get; set; }
        public string? InvolvedBy { get; set; }
        public string? PhotoPath { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }

    }
}
