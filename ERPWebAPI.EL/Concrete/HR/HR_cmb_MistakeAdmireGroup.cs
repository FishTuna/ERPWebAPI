
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_MistakeAdmireGroup :IEntity
    {
        [Key]
        public byte GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
