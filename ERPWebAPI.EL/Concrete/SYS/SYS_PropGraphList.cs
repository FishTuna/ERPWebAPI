using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_PropGraphList :IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ModuleCode { get; set; }
        public string ButtonTag { get; set; }
        public string Header {  get; set; }
        public string ProcedureName { get; set; }
    }
}
