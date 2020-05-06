using Eleva.Domain.Interfaces;
using Eleva.Domain.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eleva.Domain.Services
{
    public abstract class Service
    {
        public bool Validade<TValidation, TEntity>(TValidation validation, TEntity Entity) 
            where TValidation : AbstractValidator<TEntity> where TEntity : Entity
        {
            var validator = validation.Validate(Entity);

            if (validator.IsValid) return true;

            return false;
        }
    }
}
