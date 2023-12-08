using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_OrganisationChangeReason : IEntity
    {
        [Key]
        public byte CHANGE_REASON_ID { get; set; }
        public string CHANGE_REASON { get; set; }
    }
}
