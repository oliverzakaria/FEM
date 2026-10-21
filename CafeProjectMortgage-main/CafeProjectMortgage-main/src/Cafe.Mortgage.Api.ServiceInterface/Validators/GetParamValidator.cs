using Cafe.Mortgage.Api.ServiceModel;
using ServiceStack.FluentValidation;

namespace Cafe.Mortgage.Api.ServiceInterface.Validators
{
    public class GetParamValidator : AbstractValidator<GetParam>
    {
        public GetParamValidator()
        {
            RuleFor(r => r.ParamName).NotEmpty()
                .WithErrorCode("ParamNameIsEmpty")
                .WithMessage("ParamName is required");
        }
    }
}
