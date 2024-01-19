using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_tbl_SmlOperation : IEntity
    {
        [Key]
        public int OPERATION_ID { get; set; }
        public string TRANSACTION_ID { get; set; }
        public string MESSAGE { get; set; }
        public string SMS_NODE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGINNAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
