using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_cmb_Section : IEntity
    {
        [Key]
        public int SectionId { get; set; }
        public string? Section { get; set; }
        public int MenuId { get; set; }
        public string? MenuName { get; set; }
        public byte ModuleId { get; set; }
        public string? Module { get; set; }
        public string? ModuleCode { get; set; }
    }
}
