using FluentValidation;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class ProfileValidator : AbstractValidator<User>
    {
        public ProfileValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.UserName)
             .Cascade(CascadeMode.Stop)
             .NotEmpty()
             .WithMessage("El nombre de usuario no puede estar vacío.")
             .MinimumLength(5).WithMessage("Por favor introduzca mínimo 5 caracteres.");

            RuleFor(user => user.Name)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("El nombre no puede estar vacío.")
            .MinimumLength(3).WithMessage("Por favor introduzca mínimo 3 caracteres.")
            .Must(name => name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            .WithMessage("El nombre solo puede contener letras y espacios.");

            RuleFor(user => user.LastName)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("El apellido no puede estar vacío.")
            .MinimumLength(3).WithMessage("Por favor introduzca mínimo 3 caracteres.")
            .Must(lastName => lastName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            .WithMessage("El apellido solo puede contener letras.");

            RuleFor(user => user.Phone)
           .Cascade(CascadeMode.Stop)
           .NotEmpty()
           .WithMessage("El número de teléfono no puede estar vacío.")
           .MinimumLength(5).WithMessage("Por favor introduzca mínimo 5 caracteres.")
           .Must(phone => phone.All(c => char.IsDigit(c) || char.IsWhiteSpace(c) || c == '-'))
           .WithMessage("El número de teléfono solo puede contener dígitos, espacios, y '-'.");

            RuleFor(user => user.Email)
           .Cascade(CascadeMode.Stop)
           .NotEmpty()
           .WithMessage("El correo electrónico no puede estar vacío.")
           .EmailAddress()
           .WithMessage("Por favor introduzca un correo electrónico válido.");

        }
    }
    }
