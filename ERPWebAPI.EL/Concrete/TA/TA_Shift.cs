using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.TA
{
    public  class TA_Shift :IEntity
    {
        [Key]
        public short SHIFT_ID { get; set; }
        public string SHIFT_NAME { get; set; }
        public TimeSpan START_TIME { get; set; }
        public TimeSpan END_TIME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public string LOGINNAME { get; set; }
        public DateTime TRANSACTIONDATE { get; set; }
    }
}
