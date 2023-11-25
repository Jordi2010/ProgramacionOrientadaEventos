using BusinessLayer.Crud;
using CommonLayer.Entities;
using DataLayer.MailServices;
using FluentValidation.Results;
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
    public partial class AuthorForm : Form
    {
        private bool isEditMode = false;
        BookBusiness bookBusiness = new BookBusiness();
        private string originalPublisher;
        private string originalTitle;
        private string originalIsbn;
        private string originalGenre;

        public AuthorForm()
        {
            InitializeComponent();
            LoadAllData();
        }

        public void LoadAllData()
        {
            LoadAutoresData();
        }

        private void LoadAutoresData()
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            authorDataGridView.DataSource = authorBusiness.GetAuthor();
        }

        private void ClearAuthorForm()
        {
            authorFirstNameTextBox.Clear();
            authorLastNameTextBox.Clear();
        }

        private void authorFirstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y espacios, bloquear números y caracteres especiales
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto detiene la inserción del carácter no permitido
                MessageBox.Show("No se permiten números ni carácteres especiales.");
            }
        }

        private void authorLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten números ni carácteres especiales.");
            }
        }

        private void saveAuthorButton_Click(object sender, EventArgs e)
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            Author author = new Author();

            author.FirstName = authorFirstNameTextBox.Text;
            author.LastName = authorLastNameTextBox.Text;

            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult authorResult = authorValidator.Validate(author);

            if (!authorResult.IsValid)
            {
                foreach (var failure in authorResult.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);
                }
            }
            else
            {
                if (isEditMode == false)
                {
                    authorBusiness.AddAuthor(author);
                }
                else
                {
                    author.IdAuthor = int.Parse(authorDataGridView.CurrentRow.Cells["idAutor"].Value.ToString());
                    authorBusiness.UpdateAuthor(author);
                    isEditMode = false;
                }
                LoadAllData();
                ClearAuthorForm();
            }
        }

        private void editAuthorButton_Click(object sender, EventArgs e)
        {
            if (authorDataGridView.SelectedRows.Count > 0)
            {
                authorFirstNameTextBox.Text = authorDataGridView.CurrentRow.Cells[1].Value.ToString();
                authorLastNameTextBox.Text = authorDataGridView.CurrentRow.Cells[2].Value.ToString();
                isEditMode = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
        }

        private void deleteAuthorButton_Click(object sender, EventArgs e)
        {
            if (authorDataGridView.SelectedRows.Count > 0)
            {
                int authorId = int.Parse(authorDataGridView.CurrentRow.Cells[0].Value.ToString());

                AuthorBusiness authorBussines = new AuthorBusiness();
                Author author = new Author();

                author.IdAuthor = authorId;

                authorBussines.DeleteAuthor(author);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }
    }
}
