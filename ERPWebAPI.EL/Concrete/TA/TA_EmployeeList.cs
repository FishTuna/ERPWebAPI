﻿

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.TA
{
    public class TA_EmployeeList :IEntity
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
        public string? DEPUTYCHIEF { get; set; }
        public bool IS_TEMPORARY { get; set; }
    }
}
