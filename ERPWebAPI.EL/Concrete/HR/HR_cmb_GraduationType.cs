using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_GraduationType : IEntity
    {

        [Key]
        public byte GRADUATIONTYPEID { get; set; }
        public string GRADUATIONTYPE { get; set; }
        public byte SCHOOL_TYPE_ID { get; set; }
    }
}
