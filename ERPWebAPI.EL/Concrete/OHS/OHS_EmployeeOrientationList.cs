using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_EmployeeOrientationList : IEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsPlanned { get; set; }
        public string NameLastName { get; set; }
        public short LocationId { get; set; }
        public string Location { get; set; }
        public short DepartmentId { get; set; }
        public string Department { get; set; }
        public short JobId { get; set; }
        public string JobName { get; set; }
        public short OrientationTypeId { get; set; }
        public string OrientationType { get; set; }
        public DateTime EndDate { get; set; }
        public string UserName { get; set; }
        public int UserEmployeeId { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
