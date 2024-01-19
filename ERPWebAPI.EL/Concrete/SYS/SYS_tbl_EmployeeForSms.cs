
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_tbl_EmployeeForSms : IEntity
    {
        [Key]
        public int CONTACT_INFO_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public string? REGISTRYNO { get; set; }
        public string? EMPLOYEE_NAME { get; set; }
        public string CONTACT_INFO_TYPE { get; set; }
        public string CONTACT_TYPE { get; set; }
        public string CONTACT_INFO { get; set; }
        public string? COMPANY_NAME { get; set; }
        public string? LOCATION_NAME { get; set; }
        public string? COST_CENTER_NAME { get; set; }
        public string? DEPARTMENT_NAME { get; set; }
        public string? JOB_NAME { get; set; }
        public string? POSITION_NAME { get; set; }
        public string? COLLAR_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
