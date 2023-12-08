using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_tbl_UserPrivacyClassification : IEntity
    {
        [Key]
        public int USER_CLASSIFICATION_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte CLASSIFICATION_ID { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
