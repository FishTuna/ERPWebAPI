

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_Score :IEntity
    {
        [Key]
        public int EMPLOYEE_ID { get; set; }
        public int PERIOD_ID { get; set; }
        public float CONSISTENCY { get; set; }
        public int EVALUATION { get; set; }
        public float TOTAL_POINT { get; set; }
        public float AVERAGE_POINT { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string LOGIN_NAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
