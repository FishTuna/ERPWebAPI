using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_SchoolDepartment : IEntity
    {

        [Key]
        public int SCHOOL_DEPARTMENT_ID { get; set; }
        public string SCHOOL_DEPARTMENT_NAME { get; set; }
        public byte SCHOOL_TYPE_ID { get; set; }
    }
}
