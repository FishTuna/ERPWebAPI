using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_LanguageList : IEntity
    {
        [Key]
        public short LANGUAGEID { get; set; }
        public string LANGUAGE { get; set; }
        public string LANGUAGESHORT { get; set; }
        public short COUNTRYID { get; set; }
    }
}
