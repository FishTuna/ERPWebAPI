using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_Trainer :IEntity
    {
        [Key]
        public int TrainerId { get; set; }
        public bool IsOutSourced { get; set; }
        public bool IsPredefined { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public string? TrainerName { get; set; }
        public string? TrainerTitle { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? UserEmployee { get; set; }
    }
}
