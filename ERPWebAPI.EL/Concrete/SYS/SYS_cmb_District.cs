using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_District : IEntity
    {

        [Key]
        public int DistrictId { get; set; }
        public string? District { get; set; }
        public int TownId { get; set; }
        public string? PostalCode { get; set; }
        public string? Town { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
