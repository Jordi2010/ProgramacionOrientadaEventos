using BusinessLayer.Domain;
using CommonLayer.Entities;
using DataLayer.MailServices;
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
        public RecoverPasswordForm()
        {
            InitializeComponent();
        }

        private void backRecoverPasswordButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void recoverPasswordEmailButton_Click(object sender, EventArgs e)
        {
            PasswordBussines passwordBusiness = new PasswordBussines();
            User user = new User();
            user.Email = recoverPasswordEmailTextBox.Text;
            MessageBox.Show(passwordBusiness.RecoverPassword(user));

        }
    }
}
