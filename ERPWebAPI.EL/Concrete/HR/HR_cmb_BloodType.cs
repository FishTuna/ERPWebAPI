using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_BloodType : IEntity
    {
        [Key]
        public byte BLOODID { get; set; }
        public string? BLOODTYPE { get; set; }
    }
}
