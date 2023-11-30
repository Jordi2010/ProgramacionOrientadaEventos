using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class ChangePasswordValidator : AbstractValidator<User>
    {
        public ChangePasswordValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.newPassword)
                 .NotEmpty()
                 .WithMessage("La contraseña no puede estar vacía.");

            RuleFor(user => user.confirmPassword)
                    .NotEmpty().WithMessage("Confirme su contraseña.")
                    .Equal(user => user.newPassword)
                .WithMessage("Las contraseñas no coinciden.");
        }
    }
}
