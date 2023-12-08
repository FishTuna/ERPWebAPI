

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_Authority_Module : IEntity
    {
        [Key]
        public int ID { get; set; }
        public string MODULENAME { get; set; }
        public string MODULECODE { get; set; }
        public byte MODULE_ID { get; set; }
        public int ROLE_ID { get; set; }
        public byte AUTHORITY_TYPE { get; set; }
    }
}
