using BusinessLayer.Domain;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;
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
    public partial class ChangePasswordWithCodeForm : Form
    {
        private readonly RecoverPasswordForm recoverForm;
        private readonly LoginForm loginForm;
        public ChangePasswordWithCodeForm(RecoverPasswordForm recoverForm, LoginForm loginForm)
        {
            InitializeComponent();
            this.recoverForm = recoverForm;
            this.loginForm = loginForm;
            HideContent();
        }

        private void HideContent()
        {
            titlePasswordLabel.Visible = false;
            newPasswordLineLabel.Visible = false;
            confirmPasswordLineLabel.Visible = false;
            newPasswordTextBox.Visible = false;
            confirmPasswordTextBox.Visible = false;
            recoverPasswordButton.Visible = false;
        }

        private void ShowContent()
        {
            titlePasswordLabel.Visible = true;
            newPasswordLineLabel.Visible = true;
            confirmPasswordLineLabel.Visible = true;
            newPasswordTextBox.Visible = true;
            confirmPasswordTextBox.Visible = true;
            recoverPasswordButton.Visible = true;
        }

        private void backRecoverPasswordButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas salir? \n Si utilizas tu codigo y sales de esta ventana, perderas la oportunidad de modificar tu contraseña.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                ExitChangeRecoveryPasswordWithCode();
            }
            

        }
        
        private void ConsumeCodeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas salir? \n Si utilizas tu codigo y sales de esta ventana, perderas la oportunidad de modificar tu contraseña.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                ExitChangeRecoveryPasswordWithCode();
            }
        }
        private void ExitChangeRecoveryPasswordWithCode()
        {
            recoverForm.Close();
            this.Close();
            loginForm.ShowLoginFormControls();
            loginForm.Show();
        }

        private void ValidateCodeButton_Click(object sender, EventArgs e)
        {
            CodeRecover codeRecover = new CodeRecover();
            codeRecover.Code = CodeToRecoverTextBox.Text;
            PasswordBussines passwordBussines = new PasswordBussines();
            if (passwordBussines.VerifiedPasswordCode(codeRecover))
            {
                MessageBox.Show("Ingresa la nueva contraseña");
                CodeToRecoverTextBox.Enabled= false;
                ValidateCodeButton.Enabled= false;
                ShowContent();
            }
            else
            {
                MessageBox.Show("Codigo Invalido");
            }
        }

        private void recoverPasswordButton_Click(object sender, EventArgs e)
        {

            CodeRecover codeRecover = new CodeRecover();
            User user = new User();
            codeRecover.Code = CodeToRecoverTextBox.Text;
            user.newPassword = newPasswordTextBox.Text;
            user.confirmPassword = confirmPasswordTextBox.Text;


            ChangePasswordValidator changePasswordValidator = new ChangePasswordValidator();
            ValidationResult authorResult = changePasswordValidator.Validate(user);

            if (!authorResult.IsValid)
            {
                foreach (var failure in authorResult.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);
                }
            }
            else
            {
                user.Password= newPasswordTextBox.Text;
                PasswordBussines passwordBussines = new PasswordBussines();
                if (passwordBussines.ChangePasswordAndDeleteCode(user,codeRecover))
                {
                    MessageBox.Show("Cambio de contraseña exitoso!");
                    ExitChangeRecoveryPasswordWithCode();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, Vuelve a intentarlo mas tarde.");
                }
            }
        }
    }
}
