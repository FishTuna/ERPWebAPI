using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        [Key]
        public int ClaimId { get; set; }
        public string ClaimName { get; set; }
    }
}

