
using Core.Entities;
using System.ComponentModel.DataAnnotations;


namespace ERPWebAPI.EL.Concrete.HR
{
    public class HR_sp_AnnualLeaveDetail : IEntity
    {
        [Key]
        public byte ID { get; set; }
        public int YEARS { get; set; }
        public DateTime BEGINING {  get; set; }
        public DateTime? ENDING {  get; set; }
        public byte SENIORITY {  get; set; }
        public byte AGE {  get; set; }
        public Int16 EARNED {  get; set; }
        public float USED {  get; set; }
        public float REMAINS {get; set; }
    }
}
