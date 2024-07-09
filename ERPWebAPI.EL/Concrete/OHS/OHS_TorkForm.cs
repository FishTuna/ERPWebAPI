
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
        public short FacilityId { get; set; }
        public string? Facility { get; set; }
        public string? EventPlace { get; set; }
        public decimal ProbabilityOfOccurrence { get; set; }
        public decimal IncidenceOfRealisation { get; set; }
        public decimal ConsequenceOfOccurrence { get; set; }
        public byte TorkStatusId { get; set; }
        public string TorkStatus { get; set; }
        public bool IsTorkOwnerAnonymous { get; set; }
        public bool IsTorkOwnerEmployee { get; set; }
        public int? TorkOwnerEmployeeId { get; set; }
        public string? TorkOwnerName { get; set; }
        public bool InformSupervısor { get; set; }
        public string UserName { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
