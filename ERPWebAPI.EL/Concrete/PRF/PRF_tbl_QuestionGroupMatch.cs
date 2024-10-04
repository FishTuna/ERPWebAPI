using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_QuestionGroupMatch: IEntity
    {
        [Key]
        public int MATCH_ID { get; set; }
        public short GROUP_ID { get; set; }
        public string? GROUP_NAME { get; set; }
        public bool IS_GROUP_ACTIVE { get; set;}
        public short TITLE_ID { get; set; }
        public string? TITLE { get; set; }
        public byte QUESTION_TYPE_ID { get; set; }
        public string? QUESTION_TYPE { get; set; }
        public bool IS_QUESTION_TYPE_ACTIVE { get; set;}
        public int QUESTION_ID { get; set; }
        public string? QUESTION { get; set; }
        public bool IS_ACTIVE { get; set;}
        public byte RATINGGROUPID { get; set; }
        public string? RATING_GROUP_NAME { get; set; }
        public string? USEREMPLOYEE { get;set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
