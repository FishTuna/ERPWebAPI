

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.TA
{
    public class TA_WorkPlaceType :IEntity
    {
        [Key]
        public byte TYPE_ID { get; set; }
        public string TYPE_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGINNAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
