

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_PeriodMatch :IEntity
    {
        [Key]
        public int PERIOD_ID { get; set; }
        public string PERIOD_COMMENT { get; set; }
        public short GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public bool IS_GROUP_ACTIVE { get; set; }
        public DateTime PERIOD_BEGINING { get; set; }
        public DateTime PERIOD_ENDING { get; set; }
        public DateTime PERIOD_SCOPE_START { get; set; }
        public DateTime PERIOD_SCOPE_END { get; set; }
        public string LOGIN_NAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
