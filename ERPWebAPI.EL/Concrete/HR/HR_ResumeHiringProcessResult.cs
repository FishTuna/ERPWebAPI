using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_ResumeHiringProcessResult :IEntity
    {
        [Key]
        public byte HiringProcessResultId { get; set; }
        public string HiringProcessResult { get; set; }
        public bool CanForward { get; set; }
    }
}
