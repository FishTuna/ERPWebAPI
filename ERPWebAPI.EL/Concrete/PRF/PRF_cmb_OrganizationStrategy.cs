

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_cmb_OrganizationStrategy : IEntity
    {
        [Key]
        public short STRATEGY_ID { get; set; }
        public string STRATEGY_DESCRIPTION { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
