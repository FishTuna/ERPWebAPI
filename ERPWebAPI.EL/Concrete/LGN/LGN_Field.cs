

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_Field:IEntity
    {
        [Key]
        public int FieldId { get; set; }
        public string? Field {  get; set; }
        public int MenuId { get; set; }
        public string? MenuName { get; set; }
        public byte ModuleId { get; set; }
        public string? Module { get; set; }
        public string? ModuleCode { get; set; }
    }
}
