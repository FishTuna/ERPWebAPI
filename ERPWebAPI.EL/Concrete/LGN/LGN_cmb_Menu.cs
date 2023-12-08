using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_cmb_Menu : IEntity
    {
        [Key]
        public int MENU_ID { get; set; }
        public string MENU_NAME { get; set; }
        public byte MODULE_ID { get; set; }
    }
}
