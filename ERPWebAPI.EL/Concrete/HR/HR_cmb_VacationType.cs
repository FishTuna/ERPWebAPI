using Core.Entities;
using System.ComponentModel.DataAnnotations;
namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_VacationType : IEntity
    {


        [Key]
        public short VACATIONID { get; set; }
        public string? VACATIONNAME { get; set; }
        public string? VACATIONCODE { get; set; }
        public bool IS_ACTIVE { get; set; }
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
        public byte DATEPERIODTYPEID { get; set; }
        public string? DATEPERIODTYPE { get; set; }
        public byte MISSINGDAYID { get; set; }
        public string? MISSINGDAYREASON { get; set; }
        public DateTime? TRANSACTIONDATE {  get; set; }
        public string? USEREMPLOYEE { get; set; }
    }
}
