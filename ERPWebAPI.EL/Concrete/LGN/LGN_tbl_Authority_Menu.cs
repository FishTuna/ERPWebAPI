using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_tbl_Authority_Menu : IEntity
    {
        [Key]
        public int RowNumber { get; set; }
        public int MenuId { get; set; }
        public string? MenuName { get; set; }
        public byte ModuleId { get; set; }
        public string? ModuleCode { get; set; }
        public byte Authority { get; set; }
    }
}

