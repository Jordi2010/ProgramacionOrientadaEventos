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

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            loginContentPanel.Controls.Add(childForm);
            loginContentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {

            loginUserTextBox.Clear();
            loginPasswordTextBox.Clear();
            this.Show();
        }
        public void ShowLoginFormControls()
        {
            foreach (Control control in loginContentPanel.Controls)
            {
                control.Visible = true;
            }
        }

        private void sizeLoginButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeLoginButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
                            DashboardForm dashboardForm = new DashboardForm(user.UserName);
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

        private void loginPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Se ocultan todos los controles en el panel de contenido de inicio de sesión
            foreach (Control control in loginContentPanel.Controls)
            {
                control.Visible = false;
            }
            // Se crea una instancia del formulario de recuperación de contraseña, se configura y se muestra en el panel de contenido
            RecoverPasswordForm formRecover = new RecoverPasswordForm(this);
            formRecover.TopLevel = false;
            formRecover.FormBorderStyle = FormBorderStyle.None;
            formRecover.Dock = DockStyle.Fill;
            loginContentPanel.Controls.Add(formRecover);
            formRecover.Show();
        }

        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
            // Se ocultan todos los controles en el panel de contenido de inicio de sesión
            foreach (Control control in loginContentPanel.Controls)
            {
                control.Visible = false;
            }
            // Se crea una instancia del formulario de registro, se configura y se muestra en el panel de contenido
            RegisterForm formRegister = new RegisterForm(this);
            formRegister.TopLevel = false;
            formRegister.FormBorderStyle = FormBorderStyle.None;
            formRegister.Dock = DockStyle.Fill;
            loginContentPanel.Controls.Add(formRegister);
            formRegister.Show();
        }

        private void loginRegisterButton_MouseEnter(object sender, EventArgs e)
        {
            loginRegisterButton.BackColor = Color.RoyalBlue;
        }

        private void loginRegisterButton_MouseLeave(object sender, EventArgs e)
        {
            loginRegisterButton.BackColor = Color.Transparent;
        }

        private void SeePasswordpictureBox_Click(object sender, EventArgs e)
        {
            HidePasswordpictureBox.BringToFront();
            loginPasswordTextBox.PasswordChar = '*';
        }

        private void HidePasswordpictureBox_Click(object sender, EventArgs e)
        {
            SeePasswordpictureBox.BringToFront();
            loginPasswordTextBox.PasswordChar = '\0';
        }
    }
}
