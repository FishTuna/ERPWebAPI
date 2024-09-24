using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_ExtJob : IEntity
    {
        [Key]
        public int ExtJobId { get; set; }
        public int EmployeeId { get; set; }
        public short JobId { get; set; }
        public string? JobName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? UserEmployee { get; set; }
    }
}
