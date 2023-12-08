

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public  class OHS_cmb_EmergencyRegion : IEntity
    {
        [Key]
        public short EM_REGION_ID { get; set; }
        public string EM_REGION_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
