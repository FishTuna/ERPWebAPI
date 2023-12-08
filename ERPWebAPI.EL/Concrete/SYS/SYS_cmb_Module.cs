using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_Module : IEntity
    {


        [Key]
        public byte MODULEID { get; set; }
        public string MODULENAME { get; set; }
        public string MODULECODE { get; set; }
    }
}
