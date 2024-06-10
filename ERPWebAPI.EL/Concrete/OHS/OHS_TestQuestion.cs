

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TestQuestion : IEntity
    {
        [Key]
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int QuestionTypeId { get; set; }
        public string? QuestionType { get; set; }
        public int QuestionGroupId { get; set; }
        public string? QuestionGroup { get; set; }
        public int AnswerTypeId { get; set; }
        public string? AnswerType { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
