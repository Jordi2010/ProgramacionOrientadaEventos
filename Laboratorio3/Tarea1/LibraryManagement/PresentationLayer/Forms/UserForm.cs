using BusinessLayer.Crud;
using DataLayer.Data;
using iText.Kernel.Colors;
using PresentationLayer.Utilities;
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
    public partial class UserForm : Form
    {
        UserData userData = new UserData();

        public UserForm()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            userDataGridView.DataSource = userData.GetAllUsers();
        }

        private void userSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            UserBusiness userBusiness = new UserBusiness();
            userDataGridView.DataSource = userBusiness.SearchUser(userSearchTextBox.Text);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();

            if (userDataGridView.SelectedRows.Count > 0)
            {
                int userId = int.Parse(userDataGridView.CurrentRow.Cells["ID"].Value.ToString());

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    userData.DeleteUser(userId);
                    LoadUserData();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }

        private void pdfUserButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\jordi\OneDrive\Documentos\Usuarios_Reporte.pdf";
            try
            {
                iTextPDF userPDF = new iTextPDF();
                var document = userPDF.IniatializePDF(path);
                document.Add(userPDF.GenerateHeaderPDF("REPORTE DE USUARIOS", 16, ColorConstants.RED));
                document.Add(userPDF.GenerateTablePDF(7, userDataGridView));
                document.Close();
                MessageBox.Show("PDF generado correctamente en documentos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
