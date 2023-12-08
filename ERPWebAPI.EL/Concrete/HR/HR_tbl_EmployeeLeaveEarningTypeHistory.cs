

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public  class HR_tbl_EmployeeLeaveEarningTypeHistory :IEntity
    {
        [Key]
       
        public int HISTORY_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte LEAVE_EARNING_TYPE_ID { get; set; }
        public string LEAVE_EARNING_TYPE_NAME { get; set; }
    public DateTime BEGINDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }


    }
}
