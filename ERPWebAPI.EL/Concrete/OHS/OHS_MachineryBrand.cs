
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_MachineryBrand :IEntity
    {
        [Key]
        public short BrandId { get; set; }
        public string Brand {  get; set; }
        public string ? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
