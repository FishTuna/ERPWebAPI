
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_OrganizationPyramid:IEntity
    {
        [Key]
        public Int64 ROW_NUMBER { get; set; }
        public int TABLE_COLUMN_ID { get; set; }
        public string FIELD_NAME { get; set; }
        public short TITLE_ID { get; set; }
        public short PARENT_TITLE_ID { get; set; }
        public string TITLE { get; set; }
        public short LAYER { get; set; }
        public int NORM_STAFF { get; set; }
        public int ACTUAL_COUNT { get; set; }
    }
}
