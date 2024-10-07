

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_Authority_Role : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public int LoginId { get; set; }
        public int EmployeeId { get; set; }
        public string? Employee {  get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
