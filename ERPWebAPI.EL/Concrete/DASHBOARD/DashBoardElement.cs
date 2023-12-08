using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.DASHBOARD
{
    public class DashBoardElement : IEntity
    {
        [Key]
        public int ELEMENT_ID { get; set; }
        public string MODULECODE { get; set; }
        public string ELEMENT_TYPE_NAME { get; set; }
        public string ELEMENT_NAME { get; set; }
        public string ELEMENT_PROC { get; set; }
        public string ELEMENT_PROC_PARAMS { get; set; }
        public int ELEMENT_COLOR_RED { get; set; }
        public int ELEMENT_COLOR_GREEN { get; set; }
        public int ELEMENT_COLOR_BLUE { get; set; }
    }
}