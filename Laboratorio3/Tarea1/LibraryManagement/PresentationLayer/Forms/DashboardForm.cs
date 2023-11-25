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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void closeDashboardButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            dashboardContentPanel.Controls.Add(childForm);
            dashboardContentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AuthorForm());
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookForm());
        }

        private void loanButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoanForm());
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReturnForm());
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm());
        }

        private void authorIconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AuthorForm());
        }

        private void bookIconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookForm());
        }

        private void loanIconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoanForm());
        }

        private void returnIconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReturnForm());
        }

        private void userIconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
        }

        private void profileIconButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm());
        }

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.DarkBlue;
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.Transparent;
        }

        private void authorButton_MouseEnter(object sender, EventArgs e)
        {
            authorButton.BackColor = Color.DarkBlue;
        }

        private void authorButton_MouseLeave(object sender, EventArgs e)
        {
            authorButton.BackColor = Color.Transparent;
        }

        private void bookButton_MouseEnter(object sender, EventArgs e)
        {
            bookButton.BackColor = Color.DarkBlue;
        }

        private void bookButton_MouseLeave(object sender, EventArgs e)
        {
            bookButton.BackColor = Color.Transparent;
        }

        private void loanButton_MouseEnter(object sender, EventArgs e)
        {
            loanButton.BackColor = Color.DarkBlue;
        }

        private void loanButton_MouseLeave(object sender, EventArgs e)
        {
            loanButton.BackColor = Color.Transparent;
        }

        private void returnButton_MouseEnter(object sender, EventArgs e)
        {
            returnButton.BackColor = Color.DarkBlue;
        }

        private void returnButton_MouseLeave(object sender, EventArgs e)
        {
            returnButton.BackColor = Color.Transparent;
        }

        private void userButton_MouseEnter(object sender, EventArgs e)
        {
            userButton.BackColor = Color.DarkBlue;
        }

        private void userButton_MouseLeave(object sender, EventArgs e)
        {
            userButton.BackColor = Color.Transparent;
        }

        private void profileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.BackColor = Color.DarkBlue;
        }

        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            profileButton.BackColor = Color.Transparent;
        }

        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.BackColor = Color.DarkBlue;
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.BackColor = Color.Transparent;
        }
    }
}
