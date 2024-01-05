

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_OrganizationTarget :IEntity
    {
        [Key]
        public int TARGET_ID { get; set; }
        public string TARGET_DESCRIPTION { get; set; }
        public short PROCESS_TYPE_ID { get; set; }
        public string PROCESS_TYPE_NAME { get; set; }
        public string DEPARTMENT { get; set; }
        public short STRATEGY_ID { get; set; }
        public string STRATEGY_DESCRIPTION { get; set; }
        public short TARGET_TYPE_ID { get; set; }
        public string TARGET_TYPE { get; set; }
        public byte YEAR_ID { get; set; }
        public short YEARS { get; set; }
        public short UNIT_TYPE_ID { get; set; }
        public string UNIT_TYPE { get; set; }
        public float TARGET { get; set; }
        public float ACTUALIZATION { get; set; }
        public float ACTUALIZATION_RATIO { get; set; }
        public byte BENCMARK_SCORE { get; set; }

    }
}
