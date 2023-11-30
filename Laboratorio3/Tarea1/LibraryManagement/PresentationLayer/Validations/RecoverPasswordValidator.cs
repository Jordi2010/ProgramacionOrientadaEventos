using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class RecoverPasswordValidator : AbstractValidator<User>
    {
        public RecoverPasswordValidator() 
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.Email)
                     .Cascade(CascadeMode.Stop)
                     .NotEmpty().WithMessage("El email no puede estar vacío.")
                     .EmailAddress().WithMessage("El formato del correo electrónico es incorrecto.");

     
        }
    }
}
