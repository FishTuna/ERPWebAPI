using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_DatePeriodType : IEntity
    {
        [Key]
        public byte DATEPERIOD_TYPE_ID { get; set; }
        public string DATEPERIOD_TYPE { get; set; }
        public byte UPPER_TYPE_ID { get; set; }
        public byte UPPER_TYPE_VALUE { get; set; }
        public byte LOWER_TYPE_ID { get; set; }
        public byte LOWER_TYPE_VALUE { get; set; }
        public string STAMP { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
