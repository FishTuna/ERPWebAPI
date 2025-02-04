using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_NaceCode:IEntity
    {
        [Key]
        public short NaceId { get; set; }
        public string? NaceCode { get; set; }
        public string? Description { get; set; }
        public byte DangerClassId { get; set; }
        public string? DangerClass {  get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
