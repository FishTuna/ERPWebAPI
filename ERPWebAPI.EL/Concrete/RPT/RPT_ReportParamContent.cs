using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.RPT
{
    public class RPT_ReportParamContent :IEntity
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
    }
}
