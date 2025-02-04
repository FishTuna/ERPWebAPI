using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_RoleModule:IEntity
    {
        [Key]
        public int RowNumber { get; set; }
        public int RoleId { get; set; }
        public byte ModuleId { get; set; }
        public string? Module { get; set; }
        public byte Authority { get; set; }
        public string? ModuleCode { get; set; }
    }
}
