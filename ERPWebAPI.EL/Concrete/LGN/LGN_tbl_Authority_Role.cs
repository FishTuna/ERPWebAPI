

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_Authority_Role : IEntity
    {
        [Key]
        public int ID { get; set; }
        public int ROLE_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
    }
}
