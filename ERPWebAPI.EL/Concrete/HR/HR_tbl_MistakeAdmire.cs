using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_MistakeAdmire : IEntity
    {
        [Key]
        public int ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte TYPE_ID { get; set; }
        public string? COMMENT { get; set; }
        public string? CERTIFICATEPATH { get; set; }
        public DateTime DATE { get; set; }
        public int USER_EMPLOYEEID { get; set; }
        public bool ISACTIVE { get; set; }
    }
}
