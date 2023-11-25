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
    public partial class LoanForm : Form
    {
        private bool isEditMode = false;
        BookBusiness bookBusiness = new BookBusiness();
        private string originalPublisher;
        private string originalTitle;
        private string originalIsbn;
        private string originalGenre;

        public LoanForm()
        {
            InitializeComponent();

            LoadAllData();
        }

        public void LoadAllData()
        {
            /*LoadBookData();
            LoadAutoresData();
            LoadAutoresComboBoxData();
            LoadStatusComboBoxData();*/
            LoadLoanData();
            //LoadReturnData();
            LoadBookComboBoxData();
            /*LoadLoanComboBoxData();
            statusLoanCoamboBoxData();*/
        }

        private void LoadLoanData()
        {
            LoanBusiness LoanBusiness = new LoanBusiness();
            loanDataGridView.DataSource = LoanBusiness.GetLoan();
        }

        private void LoadBookComboBoxData()
        {
            BookBusiness bookBussines = new BookBusiness();
            loanBookComboBox.DataSource = bookBussines.GetBookFilter();
            loanBookComboBox.DisplayMember = "nombreLibro";
            loanBookComboBox.ValueMember = "idLibro";
        }

        private void saveLoanButton_Click(object sender, EventArgs e)
        {
            LoanBusiness loanBusiness = new LoanBusiness();
            Loan loan = new Loan();

            BookBusiness bookBusiness = new BookBusiness();
            Book book = new Book();

            loan.IdBook = Convert.ToInt32(loanBookComboBox.SelectedValue);
            loan.Customer = loanCustomerTextBox.Text;
            loan.LoanDate = loanDateDateTimePicker.Value;
            loan.ReturnEstimatedDate = loanReturnDateDateTimePicker.Value;
            loan.IdLoanStatus = 2;

            LoanValidator loanvalidator = new LoanValidator();
            ValidationResult loanResults = loanvalidator.Validate(loan);

            if (!loanResults.IsValid)
            {
                foreach (var failure in loanResults.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fué el siguiente: " + failure.ErrorMessage);

                }
            }
            else
            {
                TimeSpan diferencia = loan.ReturnEstimatedDate - loan.LoanDate;
                if (diferencia <= TimeSpan.FromHours(48))
                {
                    if (diferencia == TimeSpan.FromHours(48))
                    {
                        DialogResult result = MessageBox.Show("Tu préstamo vencerá en exactamente 48 horas. ¿Deseas continuar?", "Notificación de Vencimiento", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Tu préstamo vencerá en menos de 48 horas. ¿Deseas continuar?", "Notificación de Vencimiento", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La fecha de vencimiento seleccionada es mayor a 48 horas.", "Notificación de Vencimiento", MessageBoxButtons.OK);
                }
                if (isEditMode)
                {
                    loan.IdBook = int.Parse(loanDataGridView.CurrentRow.Cells["idPrestamo"].Value.ToString());
                    loanBusiness.UpdateLoan(loan);
                    isEditMode = false;
                }
                else
                {
                    try
                    {
                        loanBusiness.AddLoan(loan);

                        book.IdBook = Convert.ToInt32(loanBookComboBox.SelectedValue);
                        book.IdStatus = 2;
                        bookBusiness.UpdateBookStatus(book);
                        LoadAllData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    loanCustomerTextBox.Clear();
                }
            }
            LoadLoanData();
        }

        private void deleteLoanButton_Click(object sender, EventArgs e)
        {
            BookBusiness bookBusiness = new BookBusiness();
            Book book = new Book();

            if (loanDataGridView.SelectedRows.Count > 0)
            {
                int loanId = int.Parse(loanDataGridView.CurrentRow.Cells[0].Value.ToString());

                LoanBusiness loanBusiness = new LoanBusiness();
                Loan loan = new Loan();

                loan.IdLoan = loanId;

                loanBusiness.DeleteLoan(loan);
                int idbook = int.Parse(loanDataGridView.CurrentRow.Cells["IDL"].Value.ToString());
                book.IdBook = idbook;
                book.IdStatus = 1;
                bookBusiness.UpdateBookStatus(book);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }
    }
}
