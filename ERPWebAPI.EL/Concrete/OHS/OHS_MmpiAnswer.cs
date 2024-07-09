

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_MmpiAnswer:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int MmpiId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int? AnswerId { get; set; }
        public string? Answer { get; set; }
        public string? AnswerGroup { get; set; }
        public string? QuestionGroupHeader { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
