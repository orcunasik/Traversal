using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.DTOs;

namespace Traversal.Service.Validations
{
    public class AboutDtoValidator : AbstractValidator<AboutDto>
    {
        public AboutDtoValidator() 
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage("{PropertyName} Boş Geçilemez")
                .NotEmpty().WithMessage("{PropertyName} Boş Geçilemez")
                .MaximumLength(100).WithMessage("{PropertyName} 100 Karakterden Fazla Olamaz")
                .MinimumLength(3).WithMessage("{PropertyName} 3 Karakterden Az Olamaz");
            RuleFor(x => x.Title2)
                .NotNull().WithMessage("{PropertyName} Boş Geçilemez")
                .NotEmpty().WithMessage("{PropertyName} Boş Geçilemez")
                .MaximumLength(30).WithMessage("{PropertyName} 100 Karakterden Fazla Olamaz")
                .MinimumLength(3).WithMessage("{PropertyName} 3 Karakterden Az Olamaz");
            RuleFor(x => x.Description)
                .NotNull().WithMessage("{PropertyName} Boş Geçilemez")
                .NotEmpty().WithMessage("{PropertyName} Boş Geçilemez")
                .MaximumLength(350).WithMessage("{PropertyName} 100 Karakterden Fazla Olamaz")
                .MinimumLength(10).WithMessage("{PropertyName} 10 Karakterden Az Olamaz");
            RuleFor(x => x.Description2)
                .NotNull().WithMessage("{PropertyName} Boş Geçilemez")
                .NotEmpty().WithMessage("{PropertyName} Boş Geçilemez")
                .MaximumLength(350).WithMessage("{PropertyName} 100 Karakterden Fazla Olamaz")
                .MinimumLength(10).WithMessage("{PropertyName} 10 Karakterden Az Olamaz");
            RuleFor(x => x.Image)
                .NotNull().WithMessage("{PropertyName} Boş Geçilemez")
                .NotEmpty().WithMessage("{PropertyName} Boş Geçilemez")
                .MaximumLength(350).WithMessage("{PropertyName} 100 Karakterden Fazla Olamaz")
                .MinimumLength(10).WithMessage("{PropertyName} 10 Karakterden Az Olamaz");

        }
    }
}
