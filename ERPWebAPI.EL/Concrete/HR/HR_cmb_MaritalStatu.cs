using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_MaritalStatu : IEntity
    {
        [Key]
        public byte MARITALID { get; set; }
        public string STATUSNAME { get; set; }
        public short LANGUAGEID { get; set; }
    }
}
