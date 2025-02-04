using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.OHS
{
    public class OHS_DangerClass :IEntity
    {
        [Key]
        public byte DangerClassId { get; set; }
        public string? DangerClass {  get; set; }
        public byte CertificateValidityDuration { get; set; }
        public byte HealthReportValidityDuration { get; set; }
        public string? Rgb {  get; set; }
    }
}
