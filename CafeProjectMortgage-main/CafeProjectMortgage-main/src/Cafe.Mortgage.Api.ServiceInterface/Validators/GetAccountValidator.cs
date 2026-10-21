using Cafe.Mortgage.Api.ServiceModel;
using ServiceStack.FluentValidation;

namespace Cafe.Mortgage.Api.ServiceInterface.Validators
{
    public class GetAccountValidator : AbstractValidator<GetAccount>
    {
        public GetAccountValidator()
        {
            RuleFor(r => r.ServiceId).NotEmpty()
                .WithErrorCode("ServiceIdIsEmpty")
                .WithMessage("ServiceId is required");
            RuleFor(r => r.AccountNo).NotEmpty()
                .WithErrorCode("AccountNoIsEmpty")
                .WithMessage("AccountNo is required");
        }
    }
}
