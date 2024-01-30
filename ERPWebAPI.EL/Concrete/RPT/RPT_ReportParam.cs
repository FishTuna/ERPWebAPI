
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.RPT
{
    public class RPT_ReportParam :IEntity
    {
        [Key]
        public int PARAM_ID { get; set; }
        public string PARAM_HEADER { get; set; }
        public string PARAM_TYPE_NAME { get; set; }
        public string? TABLE_NAME { get; set; }
        public bool IS_MULTISELECT { get; set; }
        public byte PARAM_ORDER { get; set; }
    }
}
