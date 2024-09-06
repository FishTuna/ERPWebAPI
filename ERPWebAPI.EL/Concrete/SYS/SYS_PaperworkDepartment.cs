

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_PaperworkDepartment : IEntity
    {
        [Key]
        public short PaperworkDepartmentId { get; set; }
        public string PaperworkDepartment { get; set; }
        public string PaperworkDepartmentCode { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
