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
        private LoginForm loginFormInstance;
        private string username;
        private Button selectedButton = null;
        private Button currentButton;
        public DashboardForm(string username)
        {
            InitializeComponent();
            // Asignar el nombre de usuario a la variable de clase
            this.username = username;

            // Mostrar el nombre de usuario en el label
            dashboardWelcomeLabel.Text = "¡Bienvenido, " + this.username + "!";

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton(); // Desactiva el color del último botón presionado
                currentButton = (Button)senderBtn;
                currentButton.BackColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Transparent;
            }
        }
        private void closeDashboardButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Metodo para mostror el contenido al darle clic al boton de inicio
        private void ShowDashboardContent()
        {
            foreach (Control control in dashboardContentPanel.Controls)
            {
                control.Visible = false;
            }

            dashboardLabel.Visible = true;
            dashboardWelcomeLabel.Visible = true;
            authorIconButton.Visible = true;
            bookIconButton.Visible = true;
            loanIconButton.Visible = true;
            returnIconButton.Visible = true;
            userIconButton.Visible = true;
            profileIconButton.Visible = true;
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
            ActivateButton(sender, Color.DarkBlue);
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookForm());
            ActivateButton(sender, Color.DarkBlue);
        }

        private void loanButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoanForm());
            ActivateButton(sender, Color.DarkBlue);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReturnForm());
            ActivateButton(sender, Color.DarkBlue);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
            ActivateButton(sender, Color.DarkBlue);
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm());
            ActivateButton(sender, Color.DarkBlue);
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
            if (currentButton != homeButton)
            {
                homeButton.BackColor = Color.Transparent;
            }
        }

        private void authorButton_MouseEnter(object sender, EventArgs e)
        {
            authorButton.BackColor = Color.DarkBlue;
        }

        private void authorButton_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != authorButton)
            {
                authorButton.BackColor = Color.Transparent;
            }
        }

        private void bookButton_MouseEnter(object sender, EventArgs e)
        {
            bookButton.BackColor = Color.DarkBlue;
        }

        private void bookButton_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != bookButton)
            {
                bookButton.BackColor = Color.Transparent;
            }
        }

        private void loanButton_MouseEnter(object sender, EventArgs e)
        {
            loanButton.BackColor = Color.DarkBlue;
        }

        private void loanButton_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != loanButton)
            {
                loanButton.BackColor = Color.Transparent;
            }
        }

        private void returnButton_MouseEnter(object sender, EventArgs e)
        {
            returnButton.BackColor = Color.DarkBlue;
        }

        private void returnButton_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != returnButton)
            {
                returnButton.BackColor = Color.Transparent;
            }
        }

        private void userButton_MouseEnter(object sender, EventArgs e)
        {
            userButton.BackColor = Color.DarkBlue;
        }

        private void userButton_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != userButton)
            {
                userButton.BackColor = Color.Transparent;
            }
        }

        private void profileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.BackColor = Color.DarkBlue;
        }

        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != profileButton)
            {
                profileButton.BackColor = Color.Transparent;
            }
        }

        private void logoutButton_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.BackColor = Color.DarkBlue;
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            if (currentButton != logoutButton)
            {
                logoutButton.BackColor = Color.Transparent;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.DarkBlue);
            ShowDashboardContent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual (DashboardForm)
            this.Hide();

            // Mostrar el formulario de inicio de sesión (LoginForm) si no hay una instancia existente
            if (loginFormInstance == null || loginFormInstance.IsDisposed)
            {
                loginFormInstance = new LoginForm();
                loginFormInstance.Show();
            }

        }

        private void minimizeDashboardButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sizeDashboardButton_Click(object sender, EventArgs e)
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
    }
}
