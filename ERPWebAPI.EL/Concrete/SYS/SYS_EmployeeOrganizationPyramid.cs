

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_EmployeeOrganizationPyramid:IEntity
    {
        [Key]
        public int EMPLOYEE_ID { get; set; }
        public string? REGISTRYNO { get; set; }
        public string? NAME { get; set; }
        public string? LASTNAME { get; set; }
        public string? BLOODTYPE { get; set; }
        public string? COMPANY_NAME { get; set; }
        public string? LOCATION_NAME { get; set; }
        public string? COST_CENTER_NAME { get; set; }
        public string? DEPARTMENT_NAME { get; set; }
        public string? JOB_NAME { get; set; }
        public string? POSITION_NAME { get; set; }
        public string? COLLAR_NAME { get; set; }
        public string? PHOTOPATH { get; set; }
        public short LAYER { get; set; }
        public bool IS_TEMPORARY { get; set; }
        public short PARENT_TITLE_ID { get; set; }
        public int PARENT_EMPLOYEE_ID { get; set; }
    }
}
