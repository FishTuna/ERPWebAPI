using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_tbl_MistakeAdmire : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public byte TypeId { get; set; }
        public string? TypeName { get; set; }
        public byte GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? Comment { get; set; }
        public int DocumentID { get; set; }
        public string? DocumentPath { get; set; }
        public DateTime? ValidityDate { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool IsActive { get; set; }
    }
}
