using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.GRAPHS
{
    public class CommonGraph : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string SERIES { get; set; }
        public string ARGUMENT { get; set; }
        public decimal VALUE { get; set; }
    }
}
