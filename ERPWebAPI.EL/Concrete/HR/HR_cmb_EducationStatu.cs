using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_EducationStatu : IEntity
    {


        [Key]
        public byte EDUCATIONSTATUSTYPEID { get; set; }
        public string EDUCATIONSTATUSTYPE { get; set; }
        public short LANGUAGEID { get; set; }
    }
}
