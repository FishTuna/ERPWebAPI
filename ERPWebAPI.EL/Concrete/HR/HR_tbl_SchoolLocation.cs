using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_SchoolLocation : IEntity
    {

        [Key]
        public int SCHOOL_LOCATION_ID { get; set; }
        public short SCHOOL_COUNTRY_ID { get; set; }
        public int SCHOOL_CITY_ID { get; set; }
        public int SCHOOL_ID { get; set; }
    }
}
