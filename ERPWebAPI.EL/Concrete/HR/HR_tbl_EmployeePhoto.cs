

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_EmployeePhoto : IEntity
    {
        [Key]
        public int ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public string PHOTOPATH { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public int USER_EMPLOYEEID { get; set; }
    }
}
