using BusinessLayer.Crud;
using CommonLayer.Entities;
using FluentValidation.Results;
using DataLayer.MailServices;
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
    public partial class ProfileForm : Form
    {
        private string username = User.GlobalUserName;
        public ProfileForm()
        {
            InitializeComponent();
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadLabelUserData();
        }

        private void LoadLabelUserData()
        {
            UserBusiness userBusiness = new UserBusiness();

            DataTable userData = userBusiness.GetDataUser(username);

            if (userData != null && userData.Rows.Count > 0)
            {
                profileUserViewLabel.Text = $"{userData.Rows[0]["Usuario"]}";
                profileNameViewLabel.Text = $"{userData.Rows[0]["Nombre"]}";
                profileLastNameViewLabel.Text = $"{userData.Rows[0]["Apellido"]}";
                profileEmailViewLabel.Text = $"{userData.Rows[0]["Correo"]}";
                profilePhoneViewLabel.Text = $"{userData.Rows[0]["Telefono"]}";
            }
            else
            {
                profileUserViewLabel.Text = "USUARIO ACTUALIZADO CON EXITO,RECUERDA TU NUEVO USUARIO LA PROXIMA VEZ QUE INICIES SESION.";

            }
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            profileUserTextBox.Text = profileUserViewLabel.Text;
            profileNameTextBox.Text = profileNameViewLabel.Text;
            profileLastNameTextBox.Text = profileLastNameViewLabel.Text;
            profilePhoneTextBox.Text = profilePhoneViewLabel.Text;
            profileEmailTextBox.Text = profileEmailViewLabel.Text;
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserBusiness userBusiness = new UserBusiness();

                DataTable userData = userBusiness.GetDataUser(username);

                if (userData != null && userData.Rows.Count > 0)
                {
                    User user = new User
                    {
                        IdUser = Convert.ToInt32(userData.Rows[0]["ID"]),
                        UserName = profileUserTextBox.Text,
                        Name = profileNameTextBox.Text,
                        LastName = profileLastNameTextBox.Text,
                        Phone = profilePhoneTextBox.Text,
                        Email = profileEmailTextBox.Text
                       
                    };

                    var validator = new ProfileValidator();
                    ValidationResult results = validator.Validate(user);

                    if (!results.IsValid)
                    {
                        string errorMessage = string.Join(Environment.NewLine, results.Errors.Select(error => error.ErrorMessage));
                        MessageBox.Show(errorMessage, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    userBusiness.UpdateUserData(user.IdUser, user.UserName, user.Name, user.LastName, user.Phone, user.Email);

                    LoadLabelUserData();

                    MessageBox.Show("Datos actualizados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
