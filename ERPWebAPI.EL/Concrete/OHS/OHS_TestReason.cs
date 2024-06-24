

using Core.Entities;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TestReason :IEntity
    {
        public short ReasonId { get; set; }
        public string Reason { get; set; }
        public bool IsActive { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
