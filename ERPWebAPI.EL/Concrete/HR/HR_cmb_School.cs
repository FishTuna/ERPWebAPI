using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_School : IEntity
    {

        [Key]
        public int SchoolId { get; set; }
        public string? SchoolName { get; set; }
        public byte SchoolTypeId { get; set; }
        public string? SchoolType { get; set; }
        public int SchoolLocationId { get; set; }
        public short SchoolCountryId { get; set; }
        public string? SchoolCountry { get; set; }
        public int SchoolCityId { get; set; }
        public string? SchoolCity { get; set; }
        public string? SchoolCountryCity { get; set; }
        public string? SchoolNameCountry_city { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? UserEmployee { get; set; }
    }
}
