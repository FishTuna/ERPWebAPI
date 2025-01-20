using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingType:IEntity
    {
        [Key]
        public short TrainingTypeId { get; set; }
        public string? TrainingType { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
