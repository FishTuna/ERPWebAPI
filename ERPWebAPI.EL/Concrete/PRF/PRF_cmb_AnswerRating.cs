using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_cmb_AnswerRating :IEntity
    {
        [Key]
        public byte RATING_ID { get; set; }
        public string RATING_NAME { get; set; }
        public byte RATING_SCORE { get; set; }
        public byte RATING_GROUP_ID { get; set; }
        public string RATING_GROUP_NAME { get; set; }
        public string LOGIN_NAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }

    }
}
