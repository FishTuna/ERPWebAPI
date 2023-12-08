using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_WarningType : IEntity
    {
        [Key]
        public byte WARNING_TYPE_ID { get; set; }
        public string WARNING_TYPE_NAME { get; set; }
    }
}
