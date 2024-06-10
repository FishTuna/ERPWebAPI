

using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_TorkFormScoreResult : IEntity
    {
        [Key]
        public byte Id { get; set; }
        public string Evaluation { get; set; }
        public string StatusInfo { get; set; }
        public int BaseScore { get; set; }
        public int CeilingScore { get; set; }
        public string RGB { get; set; }

    }
}
