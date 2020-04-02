using FluentValidation;
using FluentValidation.Validators;
using LNAU24.Models;

namespace LNAU24.Validator
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserSurname).Must(s => ValidateString(s)).WithMessage("Прізвище не можу бути пустим");
            RuleFor(u => u.UserName).Must(n => ValidateString(n)).WithMessage("Ім'я не можу бути пустим!");
            RuleFor(u => u.UserEmail).Must(e => ValidateString(e)).EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("Введіть коректний E-mail!");
        }


        public bool ValidateString(string stringValue)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
