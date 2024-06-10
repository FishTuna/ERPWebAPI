using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_tbl_SendedSmsList :IEntity
    {
        [Key]
        public int MESSAGE_ID { get; set; }
        public string TRANSACTION_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public string EMPLOYEE_INFO { get; set; }
        public string PHONE_NUMBER { get; set; }
        public byte STATUS { get; set; }
        public DateTime DELIVERY_DATE { get; set; }
        public string REASON { get; set; }
        public byte MESSAGE_SIZE { get; set; }
        public string MESSAGE_TYPE { get; set; }
        public string RECIPIENT_TYPE { get; set; }
        public string IYS_BRAND_CODE { get; set; }
        public byte ENCODING { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime SEND_DATE { get; set; }
        public string MESSAGE_SENDER { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
