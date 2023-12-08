using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_Location : IEntity
    {

        [Key]
        public short LOCATION_ID { get; set; }
        public string LOCATION_NAME { get; set; }
    }
}
