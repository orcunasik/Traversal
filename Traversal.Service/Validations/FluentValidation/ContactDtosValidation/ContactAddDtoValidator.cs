using FluentValidation;
using Traversal.Core.DTOs.Concretes.ContactDtos;

namespace Traversal.Service.Validations.FluentValidation.ContactDtosValidation
{
    public class ContactAddDtoValidator : AbstractValidator<ContactAddDto>
    {
        public ContactAddDtoValidator()
        {

        }
    }
}
