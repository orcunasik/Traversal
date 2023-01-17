using FluentValidation;
using Traversal.Core.DTOs.Concretes.ContactDtos;

namespace Traversal.Service.Validations.FluentValidation.ContactDtosValidation
{
    public class ContactUpdateDtoValidator : AbstractValidator<ContactUpdateDto>
    {
        public ContactUpdateDtoValidator()
        {

        }
    }
}
