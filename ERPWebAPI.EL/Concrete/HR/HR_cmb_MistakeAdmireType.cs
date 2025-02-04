using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_MistakeAdmireType : IEntity
    {
        [Key]
        public byte Id { get; set; }
        public string? TypeName { get; set; }
        public byte GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
