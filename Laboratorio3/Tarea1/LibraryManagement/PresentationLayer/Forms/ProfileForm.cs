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

            // Verificas si se encontraron datos para el usuario
            if (userData != null && userData.Rows.Count > 0)
            {
                //agregar los demas labels
                //El argumento dentro de los corchetes [""] debe ser el mismo que se obtiene de la consulta SQL
                profileUserViewLabel.Text = $"{userData.Rows[0]["Usuario"]}";
                profileNameViewLabel.Text = $"{userData.Rows[0]["Nombre"]}";
                profileLastNameViewLabel.Text = $"{userData.Rows[0]["Apellido"]}";
                //Agregar los que falten y eliminar los comentarios
            }
            else
            {
                profileUserViewLabel.Text = "Data no found";
                //en caso de no existir, agregar algun mensaje o eliminar este segmento else
            }
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            //para rellenar los textbox usando el boton edit, simplemente se pasa como parametro el value de los labels anteriores.
            profileUserTextBox.Text= profileUserViewLabel.Text;
        }

        private void saveProfileButton_Click(object sender, EventArgs e)
        {
            //se tiene que crear una validacion para evitar guardar datos vacios
            //se tiene que crear un update en la base de datos utilizando la entidad user
            User user = new User();
            user.UserName = profileEmailTextBox.Text;
            //agregar los demas parametros y de esa forma validar y hacer el update.
            //para este apartado puedes guiarte del form de cambio de contraseña para hacer el update.
            //************************************** por cada apartado realizado, eliminar los comentarios ***************************
            MessageBox.Show("Saving");
        }
    
    }
}
