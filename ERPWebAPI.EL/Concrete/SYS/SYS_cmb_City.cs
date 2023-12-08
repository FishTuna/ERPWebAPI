using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_City : IEntity
    {

        [Key]
        public int CITYID { get; set; }
        public string PLATECODE { get; set; }
        public string CITYNAME { get; set; }
        public short COUNTRYID { get; set; }
    }
}
