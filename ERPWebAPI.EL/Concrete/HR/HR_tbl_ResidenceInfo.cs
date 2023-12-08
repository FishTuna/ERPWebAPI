using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_ResidenceInfo : IEntity
    {

        [Key]
        public int RESIDENCE_INFO_ID { get; set; }
        public string RESIDENCE_NAME { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public short COUNTRY_ID { get; set; }
        public int CITY_ID { get; set; }
        public int TOWN_ID { get; set; }
        public int DISTRICT_ID { get; set; }
        public int REGION_ID { get; set; }
        public string COMMENT { get; set; }
        public DateTime TRANSACTION_DATE { get; set; }
        public int USER_EMPLOYEE_ID { get; set; }
        public string LOGIN_NAME { get; set; }
    }
}
