using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_OrganisationChangeHistory : IEntity
    {
        [Key]
        public int CHANGE_ID { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public byte CHANGE_REASON_ID { get; set; }
        public string CHANGE_REASON { get; set; }
        public int CMB_TABLE_ID { get; set; }
        public string CMB_TABLE_NAME { get; set; }
        public string CMB_TABLE_MODULE_CODE { get; set; }
        public string OLD_VALUE { get; set; }
        public string NEW_VALUE { get; set; }
        public string? COMMENT { get; set; }
        public DateTime CHANGE_BEGINING { get; set; }
        public DateTime? CHANGE_END { get; set; }
        public bool IS_ACTIVE { get; set; }
        public int USER_EMLOYEE_ID { get; set; }
        public string LOGIN_NAME { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
    }
}
