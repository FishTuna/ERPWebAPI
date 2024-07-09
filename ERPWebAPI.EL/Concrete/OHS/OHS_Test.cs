using Core.Entities;
using System.ComponentModel.DataAnnotations;



namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_Test :IEntity
    {
        [Key]
        public short TestId { get; set; }
        public string TestName { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
