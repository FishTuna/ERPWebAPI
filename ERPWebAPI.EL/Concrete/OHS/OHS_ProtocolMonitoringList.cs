

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_ProtocolMonitoringList : IEntity
    {
        [Key]
        public int ProtocolId { get; set; }
        public string OhsCompanyName { get; set; }
        public string FacilityName { get; set; }
        public string ApprovalTypeName { get; set; }
        public string ApprovedBy { get; set; }
        public int ApprovedByEmpId { get; set; }
        public string? DangerClass { get; set; }
        public byte StatusId { get; set; }
        public string? Status { get; set; }
        public string? Comment { get; set; }
        public byte ControlState { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime ProtocolDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string UserEmployee { get; set; }


    }
}
