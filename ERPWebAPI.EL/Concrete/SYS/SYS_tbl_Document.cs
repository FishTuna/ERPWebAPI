using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_tbl_Document : IEntity
    {
        [Key]
        public int DOCUMENT_ID { get; set; }
        public string DOCUMENT_COMMENT { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte DOCUMENT_TYPE_ID { get; set; }
        public string DOCUMENT_TYPE { get; set; }
        public byte CLASSIFICATION_TYPE_ID { get; set; }
        public string CLASSIFICATION_NAME { get; set; }
        public byte PRIORITY { get; set; }
        public DateTime START_OF_VALIDITY { get; set; }
        public DateTime? END_OF_VALIDITY { get; set; }
        public byte DATE_PERIOD_TYPE_ID { get; set; }
        public string DATE_PERIOD_TYPE { get; set; }
        public short VALIDITY_PERIOD { get; set; }
        public bool CALCULATEDATE { get; set; }
        public bool CHECK_VALIDITY { get; set; }
        public string DOCUMENT_PATH { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string LOGINNAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }

    }
}
