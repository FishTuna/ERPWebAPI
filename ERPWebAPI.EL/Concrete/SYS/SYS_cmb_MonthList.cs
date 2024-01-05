

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_MonthList:IEntity
    {
        [Key]
        public byte MONTH_ID {  get; set; }
        public string MONTH_NAME { get; set; }
    }
}
