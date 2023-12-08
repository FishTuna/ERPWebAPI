using Core.Entities;
using System.ComponentModel.DataAnnotations;
namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_VacationType : IEntity
    {


        [Key]
        public byte VACATIONID { get; set; }
        public string VACATIONNAME { get; set; }
        public string VACATIONCODE { get; set; }
        public bool HOURLYUSAGE { get; set; }
        public bool PAIDVACATION { get; set; }
        public bool SOCIALSECURITY { get; set; }
        public bool UNAFFECT_SENIORTY { get; set; }
        public bool MUST_COMMENT { get; set; }
        public bool IS_EQUITABLE { get; set; }
        public bool RESTRICTIONS { get; set; }
        public byte MINDAYRESTRICTION { get; set; }
        public byte MAXDAYRESTRICTION { get; set; }
        public short MINHOURRESTRICTION { get; set; }
        public short MAXHOURRESTRICTION { get; set; }
        public short VESTINGPERIOD { get; set; }
        public byte VACATIONGROUP { get; set; }
        public byte MISSINGDAYID { get; set; }
    }
}
