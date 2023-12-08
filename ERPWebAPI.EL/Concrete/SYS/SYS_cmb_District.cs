using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_District : IEntity
    {
        public SYS_cmb_District()
        {

        }

        [Key]
        public int DISTRICTID { get; set; }
        public string DISTRICTNAME { get; set; }
        public int TOWNID { get; set; }
        public string POSTALCODE { get; set; }
    }
}
