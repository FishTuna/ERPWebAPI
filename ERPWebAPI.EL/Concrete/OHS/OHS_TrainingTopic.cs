using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingTopic : IEntity
    {
        [Key]
        public short TopicId { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public short GroupId { get; set; }
        public string? GroupName { get; set; }
        public short TrainingTypeId { get; set; }
        public string? TrainingType { get; set; }
        public short Duration { get; set; }
        public byte DatePeriodTypeId { get; set; }
        public double DurationByMinute { get; set; }
        public string? DatePeriodType { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
