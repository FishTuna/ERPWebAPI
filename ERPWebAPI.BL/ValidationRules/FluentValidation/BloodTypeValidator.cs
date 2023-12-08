using ERPWebAPI.EL.Concrete.HR;
using FluentValidation;

namespace ERPWebAPI.BL.ValidationRules.FluentValidation
{
    public class BloodTypeValidator : AbstractValidator<HR_cmb_BloodType>
    {
        public BloodTypeValidator()
        {
            RuleFor(p => p.BLOODID).NotEmpty();
        }
    }
}
