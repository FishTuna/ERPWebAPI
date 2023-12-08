using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_ExtJob : IEntity
    {
        [Key]
        public int EXT_JOB_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public short JOB_ID { get; set; }
        public DateTime TRANSACTIONDATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGINNAME { get; set; }
    }
}
