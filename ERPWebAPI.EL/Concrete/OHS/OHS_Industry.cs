using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_Industry :IEntity
    {
        [Key]
        public short IndustryId { get; set; }
        public string? IndustryCode { get; set; }
        public string? Industry { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
