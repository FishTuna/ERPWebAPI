using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_MissingDayReason : IEntity
    {

        [Key]
        public byte MISSINGDAYID { get; set; }
        public string MISSINGDAYCODE { get; set; }
        public string MISSINGDAYNAME { get; set; }
    }
}
