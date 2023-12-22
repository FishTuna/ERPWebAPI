﻿

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_EmployeeList :IEntity
    {
        [Key]
        public int EMPLOYEE_ID { get; set; }
        public string REGISTRYNO {  get; set; }
        public string NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string COMPANY_NAME { get; set; }
        public string LOCATION_NAME { get; set; }
        public string COST_CENTER_NAME { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string JOB_NAME { get; set; }
        public short POSITION_ID { get; set; }
        public string POSITION_NAME { get; set; }
        public string COLLAR_NAME { get; set; }
    }
}
