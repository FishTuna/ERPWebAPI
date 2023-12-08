using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_Authority_Menu : IEntity
    {
        [Key]
        public int ID { get; set; }
        public int MENU_ID { get; set; }
        public string MENU_NAME { get; set; }
        public byte MODULE_ID { get; set; }
        public byte AUTHORITY_TYPE { get; set; }
    }
}

