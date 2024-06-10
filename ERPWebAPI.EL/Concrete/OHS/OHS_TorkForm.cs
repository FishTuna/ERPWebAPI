
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TorkForm : IEntity
    {
        [Key]
        public int Id { get; set; }
        public byte TorkTypeId { get; set; }
        public string TorkType { get; set; }
        public DateTime EventDate { get; set; }
        public short LocationId { get; set; }
        public string Location { get; set; }
        public string EventPlace { get; set; }
        public int ProbabilityOfOccurrence { get; set; }
        public int IncidenceOfRealisation { get; set; }
        public int ConsequenceOfOccurrence { get; set; }
        public byte TorkStatusId { get; set; }
        public string TorkStatus { get; set; }
        public string UserName { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
