

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.PRF
{
    public class PRF_tbl_OrganizationScoreCard : IEntity
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
        public float TARGET { get; set; }
        public short UNIT_TYPE_ID { get; set; }
        public string UNIT_TYPE { get; set; }
        public float ACTUALIZATION_TOTAL { get; set; }
        public float ACTUALIZATION_RATIO { get; set; }
        public byte BENCMARK_SCORE { get; set; }
        public float OCAK { get; set; }
        public float ŞUBAT { get; set; }
        public float MART { get; set; }
        public float NİSAN { get; set; }
        public float MAYIS { get; set; }
        public float HAZİRAN { get; set; }
        public float TEMMUZ { get; set; }
        public float AĞUSTOS { get; set; }
        public float EYLÜL { get; set; }
        public float EKİM { get; set; }
        public float KASIM { get; set; }
        public float ARALIK { get; set; }
    }
}
