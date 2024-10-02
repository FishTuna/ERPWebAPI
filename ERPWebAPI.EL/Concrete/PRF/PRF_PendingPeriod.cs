
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_PendingPeriod : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PeriodId {  get; set; }
        public  bool CanEdit { get; set; }
        public string? PeriodComment { get; set; }
        public DateTime? Beginning {  get; set; }
        public DateTime? Ending { get; set; }
        public DateTime? ScopeStart { get; set; }
        public DateTime? ScopeEnd { get; set; }
        public short PositionId { get; set; }
        public short GroupId { get; set; }
    }
}
