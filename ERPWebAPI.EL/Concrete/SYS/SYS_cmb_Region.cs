using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_Region : IEntity
    {

        [Key]
        public int REGIONID { get; set; }
        public string? REGIONNAME { get; set; }
        public int DISTRICTID { get; set; }
    }
}
