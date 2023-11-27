using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() 
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.UserName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("El nombre de usuario no puede estar vacío.");

            RuleFor(user => user.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("La contraseña no puede estar vacía.");
        }
    }
}
