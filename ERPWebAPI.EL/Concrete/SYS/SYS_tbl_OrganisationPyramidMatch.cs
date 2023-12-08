using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_tbl_OrganisationPyramidMatch :IEntity
    {
        [Key]
        public short MATCH_ID { get; set; }
        public short POSITION_ID { get; set; }
        public short TITLE_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
    }
}
