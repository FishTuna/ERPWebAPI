

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_cmb_Section : IEntity
    {
        [Key]
        public int SECTION_ID { get; set; }
        public string SECTION_NAME { get; set; }
        public byte MODULE_ID { get; set; }
    }
}
