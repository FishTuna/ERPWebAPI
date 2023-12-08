using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_Company : IEntity
    {
        [Key]
        public short COMPANY_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_SUBCONTRACTOR { get; set; }
        public bool IS_TA_MANUALLY { get; set; }
    }
}
