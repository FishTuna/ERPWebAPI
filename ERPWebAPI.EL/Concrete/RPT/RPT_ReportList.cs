
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.RPT
{
    public class RPT_ReportList :IEntity
    {
        [Key]
        public int RPT_ID { get; set; }
        public string MODULE_CODE { get; set; }
        public string RPT_TITLE { get; set; }
        public string RPT_NAME { get; set; }
        public string RPT_PROC { get; set; }
    }
}
