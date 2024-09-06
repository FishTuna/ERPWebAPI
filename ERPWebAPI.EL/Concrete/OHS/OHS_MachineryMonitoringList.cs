

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_MachineryMonitoringList : IEntity
    {
        [Key]
        public int MachineryMonitoringId { get; set; }
        public int OhsCompanyId { get; set; }
        public string? OhsCompanyName { get; set; }
        public string FacilityName { get; set; }
        public short MachineryTypeId { get; set; }
        public string? MachineryType { get; set; }
        public short MachineryBrandId { get; set; }
        public string? MachineryBrand { get; set; }
        public byte RecordTypeId { get; set; }
        public string? RecordType { get; set; }
        public string? Number { get; set; }
        public byte StatusId { get; set; }
        public string? Status { get; set; }
        public string? Comment { get; set; }
        public byte ControlState { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DocumentCheckDate { get; set; }
        public DateTime PeriodicExaminationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? UserEmployee { get; set; }
    }
}
