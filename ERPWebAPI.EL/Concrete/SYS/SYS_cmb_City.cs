using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_City : IEntity
    {

        [Key]
        public int CityId { get; set; }
        public string? PlateCode { get; set; }
        public string? City { get; set; }
        public short CountryId { get; set; }
        public string? Country { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
