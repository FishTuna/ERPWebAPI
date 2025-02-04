using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_Authority_Field : IEntity
    {
        [Key]
        public int Rownumber { get; set; }
        public int FieldId { get; set; }
        public string? Field { get; set; }
        public int MenuId { get; set; }
        public string? MenuName { get; set; }
        public byte Authority { get; set; }
    }
}
