using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_Leave : IEntity
    {
        [Key]
        public int LEAVEID { get; set; }
        public int EMPLOYEEID { get; set; }
        public string? EMPLOYEE_NAME { get; set; }
        public string? EMPLOYEE_LASTNAME { get; set; }
        public string? REGISTRY_NO { get; set; }
        public int FORMID { get; set; }
        public short VACATIONID { get; set; }
        public string? VACATION_NAME { get; set; }
        public byte VACATION_GROUP_ID { get; set; }
        public string? VACATION_GROUP_NAME { get; set; }
        public byte VACATION_GROUP_PRIORITY { get; set; }
        public bool ISPAID { get; set; }
        public bool ISHOURLY { get; set; }
        public bool UNAFFECT_SENIORITY { get; set; }
        public DateTime DATE { get; set; }
        public bool IS_WEEKOFF { get; set; }
        public bool IS_HOLIDAY { get; set; }
        public DateTime STARTDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public DateTime ONWORK_DATE { get; set; }
        public float RAW_DURATION { get; set; }
        public float DAYOFF_COUNT { get; set; }
        public float HOLIDAY_COUNT { get; set; }
        public float NET_DURATION { get; set; }
        public byte DATEPRIOD_TYPE_ID { get; set; }
        public string? DATEPERIOD_TYPE { get; set; }
        public string? COMMENT { get; set; }
        public string? VACATION_ADRESS { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string? LOGIN_NAME { get; set; }

    }
}
