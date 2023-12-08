

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.TA
{
    public class TA_TimeAttendence :IEntity
    {
        [Key]
        public Int64 TA_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public bool IS_LIMITED { get; set; }
        public string LOCATION_NAME { get; set; }
        public string EMPLOYEE_NAME { get; set; }
        public string EMPLOYEE_LASTNAME { get; set; }
        public string POSITION_NAME { get; set; }
        public short LAYER { get; set; }
        public byte WORK_PLACE_TYPE_ID { get; set; }
        public string WORK_PLACE_TYPE_NAME { get; set; }
        public string? WORKPLACE_COMMENT { get; set; }
        public DateTime DATE { get; set; }
        public short SHIFT_ID { get; set; }
        public string SHIFT_NAME { get; set; }
        public TimeSpan SHIFT_START { get; set; }
        public TimeSpan SHIFT_END { get; set; }
        public DateTime ENTRENCE_TIME { get; set; }
        public DateTime? LEAVE_TIME { get; set; }
        public TimeSpan WORK_TIME { get; set; }
        public TimeSpan OVERTIME { get; set; }
        public TimeSpan DAYOFF_OVERTIME { get; set; }
        public TimeSpan HOLIDAY_OVERTIME { get; set; }
        public string? VACATION { get; set; }
        public string LOGINNAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
