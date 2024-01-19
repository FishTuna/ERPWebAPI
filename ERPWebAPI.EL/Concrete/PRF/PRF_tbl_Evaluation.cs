
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_Evaluation:IEntity
    {
        [Key]
        public int EVALUATION_ID { get; set; }
        public int PERIOD_ID { get; set; }
        public string PERIOD_COMMENT { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public string POSITION { get; set; }
        public byte QUESTION_TYPE_ID { get; set; }
        public string QUESTION_TYPE { get; set; }
        public int QUESTION_ID { get; set; }
        public string QUESTION {  get; set; }
        public int ANSWER_ID { get; set; }
        public string ANSWER {  get; set; }
        public byte RATING_ID { get; set; }
        public string RATING_NAME { get; set; }
        public byte SCORE {  get; set; }
        public byte STATUS_ID { get; set; }
        public string STATUS_NAME { get; set; }
        public string LOGIN_NAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }

    }
}
