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
using iText.Kernel.Colors;
using PresentationLayer.Utilities;

namespace PresentationLayer.Forms
{
    public partial class ReturnForm : Form
    {
        private bool isEditMode = false;
        BookBusiness bookBusiness = new BookBusiness();
        private string originalPublisher;
        private string originalTitle;
        private string originalIsbn;
        private string originalGenre;

        public ReturnForm()
        {
            InitializeComponent();

            LoadAllData();
        }

        public void LoadAllData()
        {
            LoadReturnData();
            LoadLoanComboBoxData();
            statusLoanCoamboBoxData();
        }

        private void LoadReturnData()
        {
            ReturnBusiness ReturnBusiness = new ReturnBusiness();
            returnDataGridView.DataSource = ReturnBusiness.GetReturn();
        }

        private void LoadLoanComboBoxData()
        {
            LoanBusiness loanBusiness = new LoanBusiness();
            Loan loan = new Loan();

            // Obtén los datos
            var allData = loanBusiness.GetFilterLoan();

            if (allData.Rows.Count == 0)
            {
                // No hay datos para mostrar en el ComboBox
                returnBookComboBox.DataSource = null;
                returnCustomerNameLabel.Text = "No hay datos disponibles.";
            }
            else
            {
                // Filtra y elimina duplicados si los hay
                var distinctData = allData.AsEnumerable()
                    .GroupBy(row => row.Field<int>("idPrestamo"))
                    .Select(g => g.First())
                    .CopyToDataTable();

                returnBookComboBox.DataSource = distinctData;
                returnBookComboBox.DisplayMember = "nombreLibro";
                returnBookComboBox.ValueMember = "idPrestamo";

                if (returnBookComboBox.SelectedItem != null)
                {
                    int idPrestamo = (int)returnBookComboBox.SelectedValue;
                    loan.IdLoan = idPrestamo;

                    // Llama al método GetClientNameByLoanID que devuelve un DataTable.
                    DataTable dataTable = loanBusiness.GetClientNameByLoanID(loan);

                    // Asegúrate de que el DataTable tenga al menos una fila.
                    if (dataTable.Rows.Count > 0)
                    {
                        returnCustomerNameLabel.Text = dataTable.Rows[0]["clientePrestamo"].ToString();
                    }
                    else
                    {
                        returnCustomerNameLabel.Text = "Nombre del cliente no encontrado.";
                    }
                }
            }
        }

        private void statusLoanCoamboBoxData()
        {
            LoanStatusBusiness loanStatusBusiness = new LoanStatusBusiness();
            returnLoanStatusComboBox.DataSource = loanStatusBusiness.GetAllLoanStatus();
            returnBookComboBox.DisplayMember = "LibroCompleto";
            returnBookComboBox.ValueMember = "idPrestamo";
            returnLoanStatusComboBox.DisplayMember = "estadoPrestamo";
            returnLoanStatusComboBox.ValueMember = "idestadoPrestamo";
        }

        private void returnBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            LoanBusiness loanBusiness = new LoanBusiness();
            if (returnBookComboBox.SelectedItem != null)
            {
                // Obtén el valor seleccionado del ComboBox como un DataRowView
                DataRowView selectedRow = (DataRowView)returnBookComboBox.SelectedItem;

                // Accede al valor de idPrestamo dentro del DataRowView y conviértelo a entero
                int idPrestamo = (int)selectedRow["idPrestamo"];

                loan.IdLoan = idPrestamo;

                // Llama al método GetClientNameByLoanID que devuelve un DataTable.
                DataTable dataTable = loanBusiness.GetClientNameByLoanID(loan);

                // Asegúrate de que el DataTable tenga al menos una fila.
                if (dataTable.Rows.Count > 0)
                {
                    returnCustomerNameLabel.Text = dataTable.Rows[0]["clientePrestamo"].ToString();
                }
                else
                {
                    returnCustomerNameLabel.Text = "Nombre del cliente no encontrado.";
                }
            }
        }

        private void saveReturnButton_Click(object sender, EventArgs e)
        {
            ReturnBusiness returnBusiness = new ReturnBusiness();
            Return Return = new Return();

            LoanBusiness loanBussines = new LoanBusiness();
            Loan loan = new Loan();


            Return.IdLoan = Convert.ToInt32(returnBookComboBox.SelectedValue);
            Return.ActualReturnDate = returnDateDateTimePicker.Value;

            // Agregado: Obtén la fecha de préstamo
            DateTime fechaPrestamo = loanBussines.GetLoanDateById(Return.IdLoan);

            ReturnValidator returnvalidator = new ReturnValidator();
            ValidationResult returnResults = returnvalidator.Validate(Return);

            if (!returnResults.IsValid)
            {
                foreach (var failure in returnResults.Errors)
                {
                    MessageBox.Show("La propiedad " + failure.PropertyName + " no pasó la validación. El error fue el siguiente: " + failure.ErrorMessage);
                }
            }
            else
            {
                // Agregado: Validar que la fecha de devolución real sea mayor o igual a la fecha de préstamo
                if (Return.ActualReturnDate < fechaPrestamo)
                {
                    MessageBox.Show("La fecha de devolución real no puede ser menor a la fecha de préstamo.");
                }
                else
                {
                    if (isEditMode)
                    {
                        Return.IdReturn = int.Parse(returnDataGridView.CurrentRow.Cells["idDevoluciones"].Value.ToString());
                        returnBusiness.UpdateReturn(Return);
                        isEditMode = false;
                    }
                    else
                    {
                        loan.IdLoan = Convert.ToInt32(returnBookComboBox.SelectedValue);
                        loan.IdLoanStatus = Convert.ToInt32(returnLoanStatusComboBox.SelectedValue);
                        loanBussines.UpdateStatusLoan(loan);
                        returnBusiness.AddReturn(Return);
                    }
                }
            }
            LoadAllData();
        }

        private void deleteReturnButton_Click(object sender, EventArgs e)
        {
            if (returnDataGridView.SelectedRows.Count > 0)
            {
                int returnId = int.Parse(returnDataGridView.CurrentRow.Cells[0].Value.ToString());

                ReturnBusiness returnBusiness = new ReturnBusiness();
                Return Return = new Return();

                Return.IdReturn = returnId;

                returnBusiness.DeleteReturn(Return);
                LoadAllData();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de eliminar");
            }
        }

        private void returnSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ReturnBusiness returnBusiness = new ReturnBusiness();
            returnDataGridView.DataSource = returnBusiness.SearchReturn(returnSearchTextBox.Text);
        }

        private void pdfReturnButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\jordi\OneDrive\Documentos\Devoluciones_Reporte.pdf";
            try
            {
                iTextPDF returnPDF = new iTextPDF();
                var document = returnPDF.IniatializePDF(path);
                document.Add(returnPDF.GenerateHeaderPDF("REPORTE DE DEVOLUCIONES", 16, ColorConstants.RED));
                document.Add(returnPDF.GenerateTablePDF(4, returnDataGridView));
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
