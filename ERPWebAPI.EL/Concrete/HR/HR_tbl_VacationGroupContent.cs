using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_VacationGroupContent : IEntity
    {
        [Key]
        public short CONTENT_ID { get; set; }
        public byte VACATION_GROUP_ID { get; set; }
        public byte VACATION_TYPE_ID { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
