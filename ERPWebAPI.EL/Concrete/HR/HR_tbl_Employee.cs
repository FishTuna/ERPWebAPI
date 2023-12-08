using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_Employee : IEntity

    {
        [Key]
        public int EMPLOYEE_ID { get; set; }
        public string? SOCIALSECURITYNO { get; set; } //= string.Empty;
        public string? REGISTRYNO { get; set; } //= string.Empty;
        public string? NAME { get; set; } //= string.Empty;
        public string? SECONDNAME { get; set; } //= "";// string.Empty;
        public string? LASTNAME { get; set; }// = string.Empty;
        public string? SECONDLASTNAME { get; set; }// = string.Empty;
        public DateTime? DATEofBIRTH { get; set; }// = default(DateTime);
        public string? PLACEofBIRTH { get; set; } //= string.Empty;
        public string? MOTHERSNAME { get; set; } //= string.Empty;
        public string? FATHERSNAME { get; set; } //= string.Empty;
        public byte MaritalSTATUS { get; set; } //= default(int);
        public byte BLOODTYPE { get; set; }
        public byte MILITARY_SERVICE_STATUS { get; set; }
        public short COMPANY_ID { get; set; }
        public short LOCATION_ID { get; set; }
        public short COST_CENTER_ID { get; set; }
        public short DEPARTMENT_ID { get; set; }
        public short JOB_ID { get; set; }
        public short POSITION_ID { get; set; }
        public byte COLLAR_ID { get; set; }
        public byte LEAVE_EARNING_TYPE_ID { get; set; }
        public bool IS_TEMPORARY { get; set; }
        public bool IS_ACTIVE { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGINNAME { get; set; }
    }
}
