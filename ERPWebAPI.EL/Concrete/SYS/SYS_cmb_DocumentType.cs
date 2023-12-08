using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_DocumentType : IEntity
    {
        [Key]
        public byte DOC_TYPE_ID { get; set; }
        public string DOC_TYPE { get; set; }
        public byte PRIVACY_CLASSIFICATION_ID { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
