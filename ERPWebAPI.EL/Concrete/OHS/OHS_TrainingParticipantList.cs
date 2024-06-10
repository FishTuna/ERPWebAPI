

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingParticipantList : IEntity
    {
        [Key]
        public int TrainingId { get; set; }
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeLastName { get; set; }
        public string? EmployeeFacility { get; set; }
        public string? EmployeeDepartment { get; set; }
        public string? EmployeePosition { get; set; }
        public string? EmployeeJob { get; set; }
        public string? InvolvedBy { get; set; }
        public string? PhotoPath { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }

    }
}
