
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_MistakeAdmireType : IEntity
    {
        [Key]
        public byte ID { get; set; }
        public byte TITLE { get; set; }
    }
}
