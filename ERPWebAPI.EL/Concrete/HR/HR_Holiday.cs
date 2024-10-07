

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_Holiday :IEntity
    {
        [Key]
        public short HolidayId { get; set; }
        public string? HolidayName {  get; set; }
        public bool IsRepeated { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartingAt { get; set; }
        public byte DayAmount { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
