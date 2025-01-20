using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_cmb_EmergencyJob :IEntity
    {
        [Key]
        public short EmJobId {  get; set; }
        public string? EmJob { get; set; }
        public bool IsActive { get; set; }
        public string? UserEmployee { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
