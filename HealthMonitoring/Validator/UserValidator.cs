using FluentValidation;
using HealthMonitoring.Models;

namespace HealthMonitoring.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() {
            RuleFor(user => user.Email).NotNull().WithMessage("O e-mail não pode ser vazio.");
            RuleFor(user => user.Email).EmailAddress().WithMessage("O e-mail é inválido");
            RuleFor(user => user.Username).NotNull();
            RuleFor(user => user.Password).NotNull();
        }
    }
}
