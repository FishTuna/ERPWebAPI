

using Core.Entities;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_NormStaff :IEntity
    {
        public int NormId { get; set; }
        public int CmbTableId { get; set; }
        public int ColumnId { get; set; }
        public string? ColumnName { get; set; }
        public short FacilityId { get; set; }
        public string? FacilityName { get; set; }
        public int CountToAdd { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
