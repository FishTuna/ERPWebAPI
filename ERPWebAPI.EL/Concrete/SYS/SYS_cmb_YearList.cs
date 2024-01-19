

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public  class SYS_cmb_YearList :IEntity
    {
        [Key]
        public byte YEAR_ID {  get; set; }
        public short YEARS {  get; set; }
    }
}
