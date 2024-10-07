using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_VacationGroupContent : IEntity
    {
        [Key]
        public short ContentId { get; set; }
        public byte VacationGroupId { get; set; }
        public short VacationTypeId { get; set; }
        public string? VacationType { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
