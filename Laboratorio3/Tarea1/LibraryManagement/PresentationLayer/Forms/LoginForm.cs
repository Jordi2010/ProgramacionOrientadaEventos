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
    }
}
