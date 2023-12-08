using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_ContactInfo : IEntity
    {

        [Key]
        public int CONTACT_INFO_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte CONTACT_TYPE { get; set; }
        public byte CONTACT_INFO_TYPE { get; set; }
        public string CONTACT_NAME { get; set; }
        public string CONTACT_INFO { get; set; }
        public string INTERCOM_NO { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGINNAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
