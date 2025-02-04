using ERPWebAPI.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ERPWebAPI.EL.Concrete.LGN
{
    public class LGN_PasswordPolicy :IEntity
    {
        [Key]
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public byte MinLenght { get; set; }
        public byte MaxLenght { get;set; }
        public byte MinUpper {  get; set; }
        public byte MinLower { get; set; }
        public byte MinDigit { get; set; }
        public byte MinSymbolCount { get; set; }
        public short ChangePeriod { get; set; }
        public byte FailedAttemptCount { get; set; }
        public bool IsDefault { get; set; }
        public string? UnWantedWords { get; set; }
        public byte OldPasswordCheckCount { get; set; }
        public string? UserEmployee {  get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
