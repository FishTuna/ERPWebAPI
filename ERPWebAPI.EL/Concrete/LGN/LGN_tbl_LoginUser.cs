using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_LoginUser : IEntity
    {

        [Key]
        public int LOGIN_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public string PASSWORD { get; set; }
        public bool IS_ADMIN { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public bool LOGIN_STATUS { get; set; }
    }
}
