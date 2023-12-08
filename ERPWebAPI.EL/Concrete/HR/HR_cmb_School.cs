using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_School : IEntity
    {

        [Key]
        public int SCHOOL_ID { get; set; }
        public string SCHOOL_NAME { get; set; }
        public byte SCHOOL_TYPE_ID { get; set; }
    }
}
