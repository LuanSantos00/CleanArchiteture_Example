using FluentValidation;

namespace CleanArchitecture.Application.UseCases.DeleteUser
{
    public sealed class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
