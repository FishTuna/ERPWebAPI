

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_EducationInfo : IEntity
    {
        [Key]
        public int EDUCATION_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte SCHOOL_TYPE_ID { get; set; }
        public byte GRADUATION_TYPE_ID { get; set; }
        public int SCHOOL_ID { get; set; }
        public byte EDUCATION_STATUS_ID { get; set; }
        public int SCHOOL_DEPARTMENT_ID { get; set; }
        public DateTime GRADUATION_DATE { get; set; }
        public int DOCUMENT_ID { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public string LOGIN_NAME { get; set; }
    }
}
