using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_ContactInfoType : IEntity
    {

        [Key]
        public byte CONTACT_INFO_TYPE_ID { get; set; }
        public string CONTACT_INFO_TYPE { get; set; }
        public short LANGUAGE_ID { get; set; }
    }
}
