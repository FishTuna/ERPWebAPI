using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_cmb_Job : IEntity
    {

        [Key]
        public short JOB_ID { get; set; }
        public string JOB_NAME { get; set; }
    }
}
