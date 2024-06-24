

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_Company : IEntity
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public short? IndustryId { get; set; }
        public string? IndustryCode { get; set; }
        public string? Industry { get; set; }
        public short? IndustrySectionId { get; set; }
        public string? IndustrySectionCode { get; set; }
        public string? IndustrySection { get; set; }
        public int? NaceCodeId { get; set; }
        public string? NaceCode { get; set; }
        public string? NaceDescription { get; set; }
        public byte? DangerClassId { get; set; }
        public string? DangerClass { get; set; }
        public string? DangerRgb { get; set; }
        public string? CompanyContactName { get; set; }
        public string? CompanyIntercom { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyEmail { get; set; }
        public bool IsActive { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
