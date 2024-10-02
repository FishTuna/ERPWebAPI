

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public  class OHS_cmb_EmergencyRegion : IEntity
    {
        [Key]
        public short EmRegionId { get; set; }
        public string? EmRegion { get; set; }
        public bool IsActive { get; set; }
        public string ? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
