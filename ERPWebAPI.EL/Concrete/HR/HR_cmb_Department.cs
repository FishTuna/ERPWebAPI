using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_Department : IEntity
    {

        [Key]
        public short DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public short COST_CENTER_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
