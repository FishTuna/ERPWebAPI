using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_SchoolType : IEntity
    {
        [Key]
        public byte SCHOOL_TYPE_ID { get; set; }
        public string SCHOOL_TYPE { get; set; }
    }
}
