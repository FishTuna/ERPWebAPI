using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_StartEndHistory : IEntity
    {

        [Key]
        public int StartEndId { get; set; }
        public int EmployeeId { get; set; }
        public string? Comment { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short QuitReasonId { get; set; }
        public string? QuitReason { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
