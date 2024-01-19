

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_cmb_TargetType : IEntity
    {
        [Key]
        public short TARGET_TYPE_ID { get; set; }
        public string TARGET_TYPE_NAME { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
