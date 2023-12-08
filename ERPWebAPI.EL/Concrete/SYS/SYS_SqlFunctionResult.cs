using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.SYS
{
    public  class SYS_SqlFunctionResult : IEntity
    {
        [Key]
        public int RETURNID { get; set; }
        public bool SQLRETURN { get; set; }
        public string FUNCRESULT { get; set; }
        public string SQLMESSAGE { get; set; }
    }
}
