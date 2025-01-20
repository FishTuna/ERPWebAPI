using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingTopicGroup : IEntity
    {
        [Key]
        public short GroupId { get; set; }
        public string? GroupName { get; set; }
        public bool IsActive { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
