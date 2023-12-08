using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.DASHBOARD
{
    public class DashBoardListHeader : IEntity
    {
        [Key]
        public int HEADER_ID { get; set; }
        public int ELEMENT_ID { get; set; }
        public byte HEADER_VALUE_NO { get; set; }
        public string HEADER_VALUE { get; set; }

    }
}