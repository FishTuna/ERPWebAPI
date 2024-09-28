

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_IndustrySection :IEntity
    {
        [Key]
        public short SectionId { get; set; }
        public string? Section {  get; set; }
        public string? SectionCode { get; set; }
        public short IndustryId { get; set; }
        public string? IndustryCode { get; set; }
        public string? Industry { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
