

using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingSessionTopic :IEntity
    {
        [Key]
        public int Id { get; set; }
        public int SessionId { get; set; }
        public short TopicId { get; set; }
        public string? ManualTopic { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
