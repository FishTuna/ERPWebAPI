using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete
{
    public class SqlResult : IEntity
    {
        [Key]
        public Int32 returnId { get; set; }
        public bool sqlReturn { get; set; }
        public string sqlMessage { get; set; }
    }
}
