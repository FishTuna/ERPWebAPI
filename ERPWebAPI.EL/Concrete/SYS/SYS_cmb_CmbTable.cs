using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_CmbTable : IEntity
    {
        [Key]
        public int CMB_TABLE_ID { get; set; }
        public string CMB_TABLE_NAME { get; set; }
        public string TABLE_NAME { get; set; }
        public string CMB_TABLE_MODULE_CODE { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}
