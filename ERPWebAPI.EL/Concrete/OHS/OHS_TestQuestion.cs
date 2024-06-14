

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TestQuestion : IEntity
    {
        [Key]
        public int QuestionId { get; set; }
        public short QuestionNumber { get; set; }
        public string Question { get; set; }
        public int TestId { get; set; }
        public string? TestName { get; set; }
        public short QuestionGroupId { get; set; }
        public string? QuestionGroup { get; set; }
        public byte AnswerTypeId { get; set; }
        public string? AnswerType { get; set; }
        public bool IsActive { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
