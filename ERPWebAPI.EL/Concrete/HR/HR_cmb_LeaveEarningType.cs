

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public  class HR_cmb_LeaveEarningType : IEntity
    {
        [Key]
        public byte LEAVE_EARNING_TYPE_ID { get; set; }
        public string LEAVE_EARNING_TYPE { get; set; }

    }
}
