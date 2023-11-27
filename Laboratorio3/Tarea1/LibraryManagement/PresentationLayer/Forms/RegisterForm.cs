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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void backRegisterButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            AuthBussines authBussines = new AuthBussines();
            User user = new User();

            user.UserName = registerUserTextBox.Text;
            user.Password = registerPasswordTextBox.Text;
            user.Name= registerNameTextBox.Text;
            user.LastName=registerLastNameTextBox.Text;
            user.Email=registerEmailTextBox.Text;
            user.Phone=registerPhoneTextBox.Text;

            RegisterValidator registerValidator = new RegisterValidator();
            ValidationResult userResult = registerValidator.Validate(user);

            if (!userResult.IsValid)
            {
                foreach (var failure in userResult.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);
                }
            }
            else
            {
                try
                {
                    //var duplicatedEmailCheked = authBussines.DuplicateEmailChecker(user);
                    //if (duplicatedEmailCheked != registerEmailTextBox.Text)
                    //{
                        var rowsAffected = authBussines.RegisterUser(user);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario Creado");
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Hide();
                        }
                    //}
                    else
                    {
                        MessageBox.Show("¡Correo duplicado! \n Utiliza un Correo distinto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
    }
}
