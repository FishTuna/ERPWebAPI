

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_Paperwork : IEntity
    {
        [Key]
        public int PaperworkId { get; set; }
        public string PaperworkName { get; set; }
        public byte PaperworkTypeId { get; set; }
        public string? PaperworkType { get; set; }
        public string? PaperworkTypeCode { get; set; }
        public short PaperworkDepartmentId { get; set; }
        public string? PaperworkDepartment { get; set; }
        public string? PaperworkDepartmentCode { get; set; }
        public short PaperworkNumber { get; set; } 
        public string? PaperworkPath { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }

    }
}
