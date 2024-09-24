using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_ResidenceInfo : IEntity
    {

        [Key]
        public int ResidenceInfoId { get; set; }
        public string? ResidenceName { get; set; }
        public int EmployeeId { get; set; }
        public short CountryId { get; set; }
        public string? Country { get; set; }
        public int CityId { get; set; }
        public string? City { get; set; }
        public int Townıd { get; set; }
        public string? Town { get; set; }
        public int DistrictId { get; set; }
        public string? District { get; set; }
        public int RegionId { get; set; }
        public string? Region { get; set; }
        public string Comment { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? UserEmployee { get; set; }
    }
}
