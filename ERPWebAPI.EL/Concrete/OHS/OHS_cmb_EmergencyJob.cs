

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_cmb_EmergencyJob :IEntity
    {
        [Key]
        public short EM_JOB_ID {  get; set; }
        public string EM_JOB_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
