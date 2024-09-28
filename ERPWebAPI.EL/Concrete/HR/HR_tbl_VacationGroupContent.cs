using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_VacationGroupContent : IEntity
    {
        [Key]
        public short ContentId { get; set; }
        public short VacationGroupId { get; set; }
        public byte VacationTypeId { get; set; }
        public string? VacationType { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
