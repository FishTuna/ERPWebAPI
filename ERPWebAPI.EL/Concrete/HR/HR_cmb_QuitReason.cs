using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_QuitReason : IEntity
    {

        [Key]
        public short QUIT_REASON_ID { get; set; }
        public string QUIT_REASON { get; set; }
        public string QUIT_REASON_CODE { get; set; }
        public short LANGUAGE_ID { get; set; }
    }
}
