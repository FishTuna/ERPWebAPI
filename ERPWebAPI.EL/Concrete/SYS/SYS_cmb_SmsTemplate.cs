

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_SmsTemplate : IEntity
    {
        [Key]
        public short TEMPLATE_ID { get; set; }
        public string TEMPLATE_NAME { get; set; }
        public string MESSAGE {  get; set; }
        public string LOGIN_NAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
