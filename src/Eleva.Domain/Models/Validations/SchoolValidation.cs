using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Eleva.Domain.Models.Validations
{
    public class SchoolValidation : AbstractValidator<School>
    {
        public SchoolValidation()
        {
            RuleFor(column => column.Name)
                .NotEmpty().WithMessage("O campo nome é obrigatório")
                .Length(3, 100)
                .WithMessage("O campo nome deve ter entre 3 e 100 caracteres");

            RuleFor(column => column.Document)
                .NotEmpty().WithMessage("O campo documento é obrigatório")
                .Length(3, 100)
                .WithMessage("O campo documento deve ter entre 3 e 100 caracteres");
        }
    }
}
