using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Eleva.Domain.Models.Validations
{
    class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation()
        {
            RuleFor(column => column.PublicPlace)
                .NotEmpty().WithMessage("O campo endereço é obrigatório")
                .Length(3, 100)
                .WithMessage("O campo endereço deve ter entre 3 e 100 caracteres");

            RuleFor(column => column.Number)
                .NotEmpty().WithMessage("O campo número é obrigatório");

            RuleFor(column => column.Zipcode)
                .NotEmpty().WithMessage("O campo cep é obrigatório")
                .Length(8, 8)
                .WithMessage("O campo cep deve ter 8 caracteres");

            RuleFor(column => column.Neighborhood)
                .NotEmpty().WithMessage("O campo bairro é obrigatório")
                .Length(3, 100)
                .WithMessage("O campo bairro deve ter entre 3 e 100 caracteres");

            RuleFor(column => column.City)
                .NotEmpty().WithMessage("O campo cidade é obrigatório")
                .Length(3, 100)
                .WithMessage("O campo cidade deve ter entre 3 e 100 caracteres");

            RuleFor(column => column.State)
                .NotEmpty().WithMessage("O campo estado é obrigatório")
                .Length(2, 100)
                .WithMessage("O campo estado deve ter entre 2 e 100 caracteres");
        }
    }
}
