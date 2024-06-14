using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_InstructorList : IEntity
    {
        [Key]
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorSocialSecurityNumber { get; set; }
        public string InstructorTitle { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? UserEmployee { get; set; }

    }
}
