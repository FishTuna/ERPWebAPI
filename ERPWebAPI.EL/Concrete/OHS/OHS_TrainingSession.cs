using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingSession : IEntity
    {
        [Key]
        public int SessionId { get; set; }
        public int TrainingListId { get; set; }
        public string? TrainerSocialSecurity { get; set; }
        public string? Trainer {  get; set; }
        public DateTime? Beginning {  get; set; }
        public DateTime? Ending { get; set; }
        public string? Comment { get; set; }
        public bool ISPollingDone { get; set; }
        public string? Path {  get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
