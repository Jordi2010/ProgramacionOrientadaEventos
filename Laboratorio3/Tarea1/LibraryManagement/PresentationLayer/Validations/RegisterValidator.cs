using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class RegisterValidator : AbstractValidator<User>
    {
        public RegisterValidator() 
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.UserName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("El nombre de usuario no puede estar vacío.")
                .MinimumLength(5).WithMessage("Por favor introduzca mínimo 5 carácteres.");

            RuleFor(user => user.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("La contraseña no puede estar vacía.")
                .MinimumLength(5).WithMessage("Por favor introduzca mínimo 8 carácteres.");

            RuleFor(user => user.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("El nombre no puede estar vacía.")
                .MinimumLength(3).WithMessage("Por favor introduzca mínimo 3 carácteres.");

            RuleFor(user => user.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("El apellido no puede estar vacía.")
                .MinimumLength(3).WithMessage("Por favor introduzca mínimo 3 carácteres.");

            RuleFor(user => user.Email)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("El email no puede estar vacío.")
                    .MinimumLength(5).WithMessage("Por favor introduzca mínimo 5 caracteres.")
                    .EmailAddress().WithMessage("El formato del correo electrónico es incorrecto.");

            RuleFor(user => user.Phone)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("El numero de telefono no puede estar vacía.")
                .MinimumLength(5).WithMessage("Por favor introduzca mínimo 8 carácteres.");



        }
    }
}
