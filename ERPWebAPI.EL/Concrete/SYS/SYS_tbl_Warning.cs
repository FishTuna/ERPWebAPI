using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_tbl_Warning : IEntity
    {
        [Key]
        public int WARNING_ID { get; set; }
        public byte WARNING_TYPE_ID { get; set; }
    }
}
