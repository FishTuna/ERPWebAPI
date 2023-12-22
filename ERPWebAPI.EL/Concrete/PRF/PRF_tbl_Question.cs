

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_Question :IEntity
    {
        [Key]
        public int QUESTION_ID { get; set; }
        public string QUESTION {  get; set; }
        public byte QUESTION_TYPE_ID { get; set;}
        public string QUESTION_TYPE { get; set; }
        public bool IS_QUESTION_TYPE_ACTIVE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string LOGIN_NAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
