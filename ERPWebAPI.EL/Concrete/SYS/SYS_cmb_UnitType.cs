

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_UnitType :IEntity
    {
        [Key]
        public short UNIT_TYPE_ID { get; set; }
        public string UNIT_TYPE { get; set; }
        public string UNIT_SYMBOL { get; set; }
        public byte UNIT_TYPE_GORUP_ID { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
