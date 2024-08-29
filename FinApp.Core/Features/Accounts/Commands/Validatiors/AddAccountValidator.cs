using FinApp.Core.Features.Accounts.Commands.Models;
using FluentValidation;

namespace FinApp.Core.Features.Accounts.Commands.Validatiors
{
    public class AddAccountValidator : AbstractValidator<AddAccountCommand>
    {
        public AddAccountValidator()
        {
            ApplyValidationRules();
        }

        private void ApplyValidationRules()
        {
            RuleFor(x => x.AccountNumber).MinimumLength(5).WithMessage("Account number Min Length 5")
                .NotEmpty().WithMessage("Account Number Must be not empty")
                .NotNull().WithMessage("Account Number Must be not null")
                .MaximumLength(11).WithMessage("Account Num Max 10 nums");
        }
    }
}
