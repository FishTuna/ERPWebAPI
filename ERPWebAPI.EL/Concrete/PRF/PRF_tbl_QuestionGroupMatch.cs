using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_QuestionGroupMatch: IEntity
    {
        [Key]
        public int MATCH_ID { get; set; }
        public short GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public bool IS_GROUP_ACTIVE { get; set;}
        public short TITLE_ID { get; set; }
        public string TITLE { get; set; }
        public byte QUESTION_TYPE_ID { get; set; }
        public string QUESTION_TYPE { get; set; }
        public bool IS_QUESTION_TYPE_ACTIVE { get; set;}
        public string QUESTION { get; set; }
        public bool IS_ACTIVE { get; set;}
        public string LOGIN_NAME { get;set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
