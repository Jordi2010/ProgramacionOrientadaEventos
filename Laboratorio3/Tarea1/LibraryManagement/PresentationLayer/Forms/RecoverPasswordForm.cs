using BusinessLayer.Domain;
using CommonLayer.Entities;
using DataLayer.MailServices;
using PresentationLayer.Validations;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class RecoverPasswordForm : Form
    {
        private readonly LoginForm parentForm;
        public RecoverPasswordForm(LoginForm parentForm)
        {

            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void backRecoverPasswordButton_Click(object sender, EventArgs e)
        {
            parentForm.ShowLoginFormControls();
            parentForm.ShowLoginFormControls();
            this.Close();
        }

        private void recoverPasswordEmailButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = recoverPasswordEmailTextBox.Text;
            RecoverPasswordValidator registerValidator = new RecoverPasswordValidator();
            ValidationResult emailResult = registerValidator.Validate(user);

            if (!emailResult.IsValid)
            {
                foreach (var failure in emailResult.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);
                }
            }
            else
            {
                PasswordBussines passwordBusiness = new PasswordBussines();

                MessageBox.Show(passwordBusiness.RecoverPassword(user));
            }



        }
        private void ConsumeCodeButton_Click(object sender, EventArgs e)
        {
            ChangePasswordWithCodeForm changePasswordWithCodeForm = new ChangePasswordWithCodeForm(this, parentForm);
            parentForm.OpenChildForm(changePasswordWithCodeForm);
        }
    }
}
