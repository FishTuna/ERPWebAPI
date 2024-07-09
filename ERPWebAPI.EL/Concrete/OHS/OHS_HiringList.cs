

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_HiringList:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string SocialSecurityNo { get; set; }
        public string NameLastName { get; set; }
        public short LocationId { get; set; }
        public string Location { get; set; }
        public short DepartmentId { get; set; }
        public string Department { get; set; }
        public short JobId { get; set; }
        public string PrescribedJob { get; set; }
        public string Interviewer { get; set; }
        public string InterviewStatus { get; set; }
        public bool IsResultPositive { get; set; }
        public string ResultComment { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
