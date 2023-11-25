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
    public partial class BookForm : Form
    {
        private bool isEditMode = false;
        BookBusiness bookBusiness = new BookBusiness();
        private string originalPublisher;
        private string originalTitle;
        private string originalIsbn;
        private string originalGenre;

        public BookForm()
        {
            InitializeComponent();
            LoadAllData();
            if (bookDataGridView.Columns.Contains("idestadoLibro"))
                bookDataGridView.Columns["idestadoLibro"].Visible = false;

            if (bookDataGridView.Columns.Contains("idAutor"))
                bookDataGridView.Columns["idAutor"].Visible = false;
        }

        public void LoadAllData()
        {
            LoadBookData();
            //LoadAutoresData();
            LoadAutoresComboBoxData();
            LoadStatusComboBoxData();
            /*LoadLoanData();
            LoadReturnData();
            LoadBookComboBoxData();
            LoadLoanComboBoxData();
            statusLoanCoamboBoxData();*/
        }

        private void LoadBookData()
        {
            BookBusiness bookBusiness = new BookBusiness();
            bookDataGridView.DataSource = bookBusiness.GetBook();
        }

        private void LoadAutoresComboBoxData()
        {
            AuthorBusiness authorBusiness = new AuthorBusiness();
            bookAuthorComboBox.DataSource = authorBusiness.GetAuthor();
            DataTable authorsTable = authorBusiness.GetAuthor();
            authorsTable.Columns.Add("NombreCompleto", typeof(string), "Nombre+' '+Apellido");
            bookAuthorComboBox.DataSource = authorsTable;
            bookAuthorComboBox.DisplayMember = "NombreCompleto";
            bookAuthorComboBox.ValueMember = "ID";
        }

        private void LoadStatusComboBoxData()
        {
            StatusBusiness statusBusiness = new StatusBusiness();
            bookStatusComboBox.DataSource = statusBusiness.GetStatuses();
            bookStatusComboBox.DisplayMember = "EstadoLibro";
            bookStatusComboBox.ValueMember = "idestadoLibro";
        }

        private void ClearBookForm()
        {
            bookPublisherTextBox.Clear();
            bookTitleTextBox.Clear();
            bookIsbnTextBox.Clear();
            bookGenreTextBox.Clear();
        }

        private void bookTitleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números y espacios, bloquear caracteres especiales
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras, números y espacios.");
            }
        }

        private void bookPublisherTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras, números y espacios.");
            }
        }

        private void bookIsbnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string input = bookIsbnTextBox.Text + e.KeyChar;

            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar)) ||
                (e.KeyChar == '-' && input.Count(c => c == '-') > 4))
            {
                e.Handled = true;
            }
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            BookBusiness bookBusiness = new BookBusiness();
            Book book = new Book();

            originalPublisher = bookPublisherTextBox.Text;
            originalTitle = bookTitleTextBox.Text;
            originalIsbn = bookIsbnTextBox.Text;
            originalGenre = bookGenreTextBox.Text;

            book.Publisher = originalPublisher;
            book.Title = originalTitle;
            book.Isbn = originalIsbn;
            book.Genre = originalGenre;
            book.IdAuthor = Convert.ToInt32(bookAuthorComboBox.SelectedValue);
            book.IdStatus = Convert.ToInt32(bookStatusComboBox.SelectedValue);

            BookValidator bookvalidator = new BookValidator();
            ValidationResult bookResults = bookvalidator.Validate(book);

            if (!bookResults.IsValid)
            {
                foreach (var failure in bookResults.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);

                    switch (failure.PropertyName)
                    {
                        case "Publisher":
                            bookPublisherTextBox.Clear();
                            break;
                        case "Title":
                            bookTitleTextBox.Clear();
                            break;
                        case "Isbn":
                            bookIsbnTextBox.Clear();
                            break;
                        case "Genre":
                            bookGenreTextBox.Clear();
                            break;
                    }
                }
            }
            else
            {
                if (isEditMode)
                {
                    book.IdBook = int.Parse(bookDataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    bookBusiness.UpdateBook(book);
                    isEditMode = false;
                }
                else
                {
                    bookBusiness.AddBook(book);
                }
                // Solo limpia el formulario si la validación es exitosa y la operación se realiza correctamente
                LoadAllData();
                ClearBookForm();
            }
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            if (bookDataGridView.SelectedRows.Count > 0)
            {
                bookPublisherTextBox.Text = bookDataGridView.CurrentRow.Cells["Editorial"].Value.ToString();
                bookTitleTextBox.Text = bookDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                bookIsbnTextBox.Text = bookDataGridView.CurrentRow.Cells["ISBN"].Value.ToString();
                bookGenreTextBox.Text = bookDataGridView.CurrentRow.Cells["Género"].Value.ToString();
                bookAuthorComboBox.SelectedValue = bookDataGridView.CurrentRow.Cells["idAutor"].Value;
                bookStatusComboBox.SelectedValue = bookDataGridView.CurrentRow.Cells["idestadoLibro"].Value;

                isEditMode = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            if (bookDataGridView.SelectedRows.Count > 0)
            {
                int bookId = int.Parse(bookDataGridView.CurrentRow.Cells["ID"].Value.ToString());

                BookBusiness bookBusiness = new BookBusiness();
                Book book = new Book();

                book.IdBook = bookId;

                bookBusiness.DeleteBook(book);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }

        private void bookSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            BookBusiness bookBusiness = new BookBusiness();
            bookDataGridView.DataSource = bookBusiness.SearchBook(bookSearchTextBox.Text);
        }
    }
}
