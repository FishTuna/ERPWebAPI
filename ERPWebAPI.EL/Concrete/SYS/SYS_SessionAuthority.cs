
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_SessionAuthority : IEntity
    {
        [Key]
        public int ROWNUMBER { get; set; }
        public int EMPLOYEE_ID { get; set; }
        public int ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public byte MODULE_ID { get; set; }
        public string MODULE_NAME { get; set; }
        public byte MODULE_AUTHORITY { get; set; }
        public int MENU_ID { get; set; }
        public string MENU_NAME { get; set; }
        public byte MENU_AUTHORITY { get; set; }
        public int SECTION_ID { get; set; }
        public string SECTION_NAME { get; set; }
        public byte SECTION_AUTHORITY { get; set; }
        public int FIELD_ID { get; set; }
        public string FIELD_NAME { get; set; }
        public byte FIELD_AUTHORITY { get; set; }

    }
}
