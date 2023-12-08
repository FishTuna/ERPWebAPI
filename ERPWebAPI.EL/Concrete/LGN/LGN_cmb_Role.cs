

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_cmb_Role : IEntity
    {
        [Key]
        public int ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
    }
}
