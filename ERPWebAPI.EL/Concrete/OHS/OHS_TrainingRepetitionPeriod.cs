using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TrainingRepetitionPeriod :IEntity
    {
        [Key]

        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public short FacilityId { get; set; }
        public string? FacilityName { get; set; }
        public short RepetitionPeriod { get; set; }
        public float RepetitionPeriodByMinute { get; set; }
        public byte DateperiodTypeId { get; set; }
        public string? DatePeriodType { get; set; }
        public bool IsActive { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
