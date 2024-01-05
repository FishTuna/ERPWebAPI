

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_cmb_ProcessType : IEntity
    {
        [Key]
        public short PROCESS_TYPE_ID { get; set; }
		public string PROCESS_TYPE_NAME { get; set; }
		public int USER_EMPLOYEE_ID { get; set; }
		public DateTime TRANSACTION_DATE { get; set; }
    }
}
