using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_SmsReturnNode :IEntity
    {
        [Key]
        public int SMS_NODE_ID { get; set; }
        public string SMS_NODE { get; set; }
        public string SMS_NODE_DESCRIPTION { get; set; }
    }
}
