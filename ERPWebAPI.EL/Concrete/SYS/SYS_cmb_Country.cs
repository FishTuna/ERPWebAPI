using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_Country : IEntity
    {
        public SYS_cmb_Country()
        {

        }

        [Key]
        public short COUNTRYID { get; set; }
        public string COUNTRYCODE2Char { get; set; }
        public string COUNTRYCODE3Char { get; set; }
        public string COUNTRYNAME { get; set; }

    }
}
