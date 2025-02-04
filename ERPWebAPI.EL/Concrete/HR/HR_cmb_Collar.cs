using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_Collar : IEntity
    {
        [Key]
        public byte COLLAR_ID { get; set; }
        public string? COLLAR_NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
