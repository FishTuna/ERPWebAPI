
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_Answer :IEntity
    {
        [Key]
        public int ANSWER_ID { get; set; }
        public string ANSWER {  get; set; }
        public int QUESTION_ID { get; set; }
        public string QUESTION { get; set; }
        public byte RATING_GROUP_ID { get; set; }
        public string RATING_GROUP_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string LOGIN_NAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
