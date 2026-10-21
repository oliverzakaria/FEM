using Cafe.Mortgage.Api.ServiceModel;
using ServiceStack.FluentValidation;

namespace Cafe.Mortgage.Api.ServiceInterface.Validators
{
    public class UpdateAccountValidator : AbstractValidator<UpdateAccount>
    {
        public UpdateAccountValidator()
        {
            RuleFor(r => r.Action).NotEmpty()
                .WithErrorCode("ActionIsEmpty")
                .WithMessage("Action is required");
            RuleFor(r => r.TableName).NotEmpty()
                .WithErrorCode("TableNameIsEmpty")
                .WithMessage("TableName is required");
            RuleFor(r => r.AccountNo).NotEmpty()
                .WithErrorCode("AccountNoIsEmpty")
                .WithMessage("AccountNo is required");
            RuleFor(r => r.Data).NotEmpty()
                .WithErrorCode("DataIsEmpty")
                .WithMessage("Data is required");
        }
    }
}
