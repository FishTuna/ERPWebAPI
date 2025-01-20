using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_tbl_OrganisationPyramidMatch :IEntity
    {
        [Key]
        public short MatchId { get; set; }
        public short PositionId { get; set; }
        public string? PositionName { get; set; }
        public short TitleId { get; set; }
        public string? TitleName { get; set; }
        public short ParentTitleId { get; set; }
        public string? ParentTitleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? UserEmployee { get; set; }
    }
}
