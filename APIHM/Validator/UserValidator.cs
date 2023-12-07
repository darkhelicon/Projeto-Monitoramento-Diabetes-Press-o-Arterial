using Common;
using FluentValidation;

namespace APIHM.Validator
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Person.Email).NotNull().WithMessage("O e-mail não pode ser vazio.");
            RuleFor(user => user.Person.Email).EmailAddress().WithMessage("O e-mail é inválido");
            RuleFor(user => user.Person.Username).NotNull().WithMessage("Nome de usuário vazio");
            RuleFor(user => user.Password).NotNull();
            RuleFor(user => user.Password).Equal(o => o.PasswordConfirm).WithMessage("As senhas devem ser iguais");
        }
    }
}
