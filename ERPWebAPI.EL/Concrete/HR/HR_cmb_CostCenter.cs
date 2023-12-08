using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_CostCenter : IEntity
    {

        [Key]
        public short COST_CENTER_ID { get; set; }
        public string COST_CENTER_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
