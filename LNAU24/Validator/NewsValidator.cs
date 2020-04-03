using FluentValidation;
using LNAU24.Models;

namespace LNAU24.Validator
{
    public class NewsValidator : AbstractValidator<News>
    {
        public NewsValidator()
        {
            RuleFor(n => n.Title).Must(s => ValidateString(s)).WithMessage("Заповніть будь-ласка заголовок!");
            RuleFor(n => n.Body).Must(s => ValidateString(s)).WithMessage("Заповніть будь-ласка текст новини!");
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
