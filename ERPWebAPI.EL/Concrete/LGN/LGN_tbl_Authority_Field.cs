

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_Authority_Field : IEntity
    {
        [Key]
        public int ID { get; set; }
        public int FIELD_ID { get; set; }
        public string FIELD_NAME { get; set; }
        public int SECTION_ID { get; set; }
        public byte AUTHORITY_TYPE { get; set; }
    }
}
