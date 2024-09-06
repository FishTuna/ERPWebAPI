
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_StandardAnswer :IEntity
    {
        [Key]
        public short AnswerId { get; set; }
        public string Answer {  get; set; }
        public string UserEmployee {  get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
