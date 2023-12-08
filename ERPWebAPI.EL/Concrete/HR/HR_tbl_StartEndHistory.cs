using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_StartEndHistory : IEntity
    {

        [Key]
        public int START_END_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public string COMMENT { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime? ENDDATE { get; set; }
        public short QUIT_REASON_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGIN_NAME { get; set; }
    }
}
