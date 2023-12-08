using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_VacationGroup : IEntity
    {
        [Key]
        public byte VACATION_GROUP_ID { get; set; }
        public string VACATION_GROUP_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public byte PRIORITY { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
