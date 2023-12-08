

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.TA
{
    public  class TA_ShiftSchedule :IEntity
    {
        [Key]
        public int SCHEDULE_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public string EMPLOYEE { get; set; }
        public string POSITION { get; set; }
        public short LAYER { get; set; }
        public short SHIFT_ID { get; set; }
        public string SHIFT_NAME { get; set; }
        public DateTime SHIFT_DATE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string LOGINNAME { get; set; }
        public DateTime TRANSACTIONDATE { get; set; }
    }
}
