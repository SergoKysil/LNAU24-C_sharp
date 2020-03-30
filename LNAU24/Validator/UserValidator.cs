using FluentValidation;
using FluentValidation.Validators;
using LNAU24.Models;

namespace LNAU24.Validator
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).Must(n => ValidateString(n)).WithMessage("Поле не можу бути пустим!");
            RuleFor(u => u.UserSurname).Must(s => ValidateString(s)).WithMessage("Поле не можу бути пустим");
            RuleFor(u => u.UserEmail).EmailAddress(EmailValidationMode.Net4xRegex).WithMessage("Введіть коректний E-mail!");     
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
