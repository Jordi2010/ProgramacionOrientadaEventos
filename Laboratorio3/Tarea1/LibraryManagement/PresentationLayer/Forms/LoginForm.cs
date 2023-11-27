using BusinessLayer.Crud;
using BusinessLayer.Domain;
using CommonLayer.Entities;
using DataLayer.MailServices;
using FluentValidation.Results;
using Microsoft.VisualBasic.ApplicationServices;
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
using User = CommonLayer.Entities.User;

namespace PresentationLayer.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void closeLoginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginRegisterButton_MouseEnter(object sender, EventArgs e)
        {
            loginRegisterButton.BackColor = Color.RoyalBlue;
        }

        private void loginRegisterButton_MouseLeave(object sender, EventArgs e)
        {
            loginRegisterButton.BackColor = Color.Transparent;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.UserName = loginUserTextBox.Text;
            user.Password = loginPasswordTextBox.Text;

            UserValidator userValidator = new UserValidator();
            ValidationResult userResult = userValidator.Validate(user);

            if (!userResult.IsValid)
            {
                foreach (var failure in userResult.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);
                }
            }
            else
            {
               
                    AuthBussines authBusiness = new AuthBussines();

                try
                {
                    string hashedPassword = authBusiness.GetPasswordByUserName(user);
                    bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(loginPasswordTextBox.Text, hashedPassword);
                    if (isPasswordCorrect)
                    {
                        user.Password = hashedPassword;
                        var credentials = authBusiness.LoginUser(user);
                        if (credentials == true)
                        {
                            DashboardForm dashboardForm = new DashboardForm();
                            dashboardForm.Show();
                            dashboardForm.FormClosed += Logout;
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("El inicio de sesión no se pudo completar. Comprueba tus datos.");

                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("El inicio de sesión no se pudo completar. Comprueba tus datos.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error durante el inicio de sesión.");
                    throw; 
                }



            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {

            loginUserTextBox.Clear();
            loginPasswordTextBox.Clear();
            this.Show();
        }

        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm formRegister = new RegisterForm();
            formRegister.Show();
            this.Hide();
        }

        private void loginPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverPasswordForm formRecover = new RecoverPasswordForm();
            formRecover.Show();
            this.Hide();
        }

        private void closeLoginButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
