using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_ContactType : IEntity
    {


        [Key]
        public byte CONTACT_TYPE_ID { get; set; }
        public string CONTACT_TYPE { get; set; }
        public short LANGUAGE_ID { get; set; }
    }
}
