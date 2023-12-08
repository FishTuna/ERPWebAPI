using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_Position : IEntity
    {
        [Key]
        public short POSITION_ID { get; set; }
        public string POSITION_NAME { get; set; }
    }
}
