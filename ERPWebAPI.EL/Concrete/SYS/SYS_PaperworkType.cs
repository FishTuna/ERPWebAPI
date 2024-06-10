

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_PaperworkType : IEntity
    {
        [Key]
        public byte PaperworkTypeId { get; set; }
        public string PaperworkType { get; set; }
        public string? PaperworkTypeCode { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
