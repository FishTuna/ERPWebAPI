

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_Authority_Section : IEntity
    {

        [Key]
        public int ID { get; set; }
        public int SECTION_ID { get; set; }
        public string SECTION_NAME { get; set; }
        public int MENU_ID { get; set; }
        public byte AUTHORITY_TYPE { get; set; }
    }
}
