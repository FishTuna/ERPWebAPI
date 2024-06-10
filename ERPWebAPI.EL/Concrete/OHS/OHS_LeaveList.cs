

using Core.Entities;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_LeaveList : IEntity
    {
        public int Id { get; set; }
        public string NameLastName { get; set; }
        public short LocationId { get; set; }
        public string Location { get; set; }
        public short DepartmentId { get; set; }
        public string Department { get; set; }
        public short JobId { get; set; }
        public string JobName { get; set; }
        public short QuitReasonId { get; set; }
        public string QuitReason { get; set; }
        public string UserName { get; set; }
        public int UserEmployeeId { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
