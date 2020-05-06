using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Eleva.Domain.Models.Validations
{
    class StudentClassValidation : AbstractValidator<StudentClass>
    {
        public StudentClassValidation()
        {
            RuleFor(column => column.NumberClass)
                .NotEmpty().WithMessage("O campo número da turma é obrigatório");

            RuleFor(column => column.Name)
                .NotEmpty().WithMessage("O campo nome da turma é obrigatório")
                .Length(3, 100)
                .WithMessage("O campo nome deve ter entre 3 e 100 caracteres");

            RuleFor(column => column.Workload)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
