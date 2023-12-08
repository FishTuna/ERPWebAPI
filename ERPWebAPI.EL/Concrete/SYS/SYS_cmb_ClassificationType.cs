using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_ClassificationType : IEntity
    {
        [Key]
        public byte CLASSIFICATION_ID { get; set; }
        public string CLASSIFICATION_NAME { get; set; }
        public byte PRIORITY { get; set; }
    }
}
