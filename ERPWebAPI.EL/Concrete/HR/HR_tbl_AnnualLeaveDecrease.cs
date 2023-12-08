

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_AnnualLeaveDecrease :IEntity
    {
        [Key]
        public int ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte DECREASE_TYPE_ID { get; set; }
        public string DECREASE_TYPE_NAME { get; set; }
        public float AMOUNT { get; set; }
        public string COMMENT { get; set; }
        public DateTime VALIDITY_PERIOD { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
