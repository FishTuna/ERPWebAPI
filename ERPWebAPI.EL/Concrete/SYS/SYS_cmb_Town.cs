using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.SYS
{
    public class SYS_cmb_Town : IEntity
    {

        [Key]
        public int TOWNID { get; set; }
        public string TOWNNAME { get; set; }
        public int CITYID { get; set; }
    }
}
