using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_Town : IEntity
    {

        [Key]
        public int TownId { get; set; }
        public string? TownName { get; set; }
        public int CityId { get; set; }
        public string? City { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
