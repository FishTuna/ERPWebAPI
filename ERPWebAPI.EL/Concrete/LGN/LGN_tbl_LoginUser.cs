using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_LoginUser : IEntity
    {

        [Key]
        public int LoginId { get; set; }
        public string? LoginName { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; }
        public int EmployeeId { get; set; }
        public string? Employee {  get; set; }
        public bool IsAdUser { get; set; }
        public bool IsPrfAdmin { get; set; }
        public bool IsLocked { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
