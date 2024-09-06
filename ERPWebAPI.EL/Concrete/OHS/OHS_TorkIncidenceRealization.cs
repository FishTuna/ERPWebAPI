

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TorkIncidenceRealization:IEntity
    {
        [Key]
        public byte Id { get; set; }
        public string StatusName { get; set; }
        public decimal StatusPoint { get; set; }
    }
}
