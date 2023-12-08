using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_Disability : IEntity
    {

        [Key]
        public int DISABILITY_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte PERCENTAGE { get; set; }
        public string DISABILITY_CAUSE { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
    }
}
