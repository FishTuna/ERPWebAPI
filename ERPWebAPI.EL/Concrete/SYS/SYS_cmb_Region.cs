using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_Region : IEntity
    {

        [Key]
        public int RegionId { get; set; }
        public string? Region { get; set; }
        public int DistrictId { get; set; }
        public string? District { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
