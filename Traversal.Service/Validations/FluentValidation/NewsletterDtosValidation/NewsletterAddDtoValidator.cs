using FluentValidation;
using Traversal.Core.DTOs.Concretes.NewsletterDtos;

namespace Traversal.Service.Validations.FluentValidation.NewsletterDtosValidation
{
    public class NewsletterAddDtoValidator : AbstractValidator<NewsletterAddDto>
    {
        public NewsletterAddDtoValidator()
        {

        }
    }
}
