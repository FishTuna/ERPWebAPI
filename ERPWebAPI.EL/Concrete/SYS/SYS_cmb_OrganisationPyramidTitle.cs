using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_OrganisationPyramidTitle :IEntity
    {
        [Key]
        public short TITLE_ID { get; set; }
        public string TITLE { get; set; }
        public short LAYER {  get; set; }
        public bool IS_ACTIVE { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
    }
}
