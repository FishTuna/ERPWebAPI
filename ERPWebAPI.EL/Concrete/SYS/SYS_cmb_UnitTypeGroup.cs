

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_UnitTypeGroup :IEntity
    {
        [Key]
        public byte UNIT_TYPE_GORUP_ID {  get; set; }
        public string UNIT_TYPE_GORUP_NAME { get; set; }
        public int USER_EMPLOYEE_ID {  get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
