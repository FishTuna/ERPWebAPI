using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.DASHBOARD
{
    public class DashBoardListDetail : IEntity
    {
        [Key]
        public int VALUE_ID { get; set; }
        public string VALUE1 { get; set; }
        public string VALUE2 { get; set; }
        public string VALUE3 { get; set; }
        public string VALUE4 { get; set; }
        public string VALUE5 { get; set; }
        public string VALUE6 { get; set; }
        public string VALUE7 { get; set; }
        public string VALUE8 { get; set; }
        public string VALUE9 { get; set; }
        public string VALUE10 { get; set; }
    }
}