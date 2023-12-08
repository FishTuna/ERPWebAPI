
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_LeaveEarning : IEntity
    {
        [Key]
        public short ID { get; set; }
        public byte LEAVE_EARNING_TYPE_ID { get; set; }
        public byte AFFECTED_VACATION_ID { get; set; }
        public byte BOTTOM_SENIORITY { get; set; }
        public byte TOP_SENIORITY { get; set; }
        public byte BOTTOM_AGE { get; set; }
        public byte TOP_AGE { get; set; }
        public DateTime VALIDITY_BEGINNING { get; set; }
        public DateTime VALIDITY_ENDING { get; set; }
        public byte EARNED { get; set; }
    }
}
