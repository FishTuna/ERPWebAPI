using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_MilitaryStatusType : IEntity
    {
        [Key]
        public byte MILITARYSTATUSTYPE_ID { get; set; }
        public string MILITARYSTATUSTYPE_NAME { get; set; }
        public short LANGUAGEID { get; set; }
    }
}
