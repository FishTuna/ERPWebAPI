
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_StandardAnswerType: IEntity
    {
        [Key]
        public byte AnswerTypeId { get; set; }
        public string AnswerTypeName { get; set; }
        public string UserEmployee {  get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
