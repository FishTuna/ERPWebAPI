using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_VacationGroup : IEntity
    {
        [Key]
        public byte VacationGroupId { get; set; }
        public string? VacationGroupName { get; set; }
        public bool IsActive { get; set; }
        public byte Priority { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
