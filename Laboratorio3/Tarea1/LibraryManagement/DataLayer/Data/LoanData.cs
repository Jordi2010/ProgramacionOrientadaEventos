using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class LoanData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable booksTable = new DataTable();

        public DataTable GetAllLoan()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = " select prestamos.idPrestamo AS ID, libros.nombreLibro AS Libro, prestamos.clientePrestamo AS Cliente,estadoPrestamo.estadoPrestamo AS Estado,prestamos.fechaPrestamo AS [Fecha de préstamo],prestamos.fechaDevolucionEstimada AS [Fecha de devolución] from prestamos inner join estadoPrestamo on prestamos.idestadoPrestamo = estadoPrestamo.idestadoPrestamo inner join libros on prestamos.idLibro = libros.idLibro;";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public DataTable GetClientNameByLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT prestamos.idPrestamo, libros.nombreLibro, prestamos.clientePrestamo, estadoPrestamo.estadoPrestamo " +
                           "FROM prestamos " +
                           "INNER JOIN estadoPrestamo ON prestamos.idestadoPrestamo = estadoPrestamo.idestadoPrestamo " +
                           "INNER JOIN libros ON prestamos.idLibro = libros.idLibro " +
                           "WHERE prestamos.idPrestamo = @IdLoan";

            _sqlCommand.CommandType = CommandType.Text;

            // Crea un parámetro para el ID del préstamo
            SqlParameter idLoanParam = new SqlParameter("@IdLoan", loan.IdLoan);
            idLoanParam.Value = loan.IdLoan;
            _sqlCommand.Parameters.Add(idLoanParam);

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public DataTable GetFilterLoan()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "select prestamos.idPrestamo, libros.nombreLibro, prestamos.clientePrestamo,estadoPrestamo.estadoPrestamo, prestamos.fechaDevolucionEstimada, prestamos.fechaPrestamo, prestamos.idLibro, prestamos.idestadoPrestamo from prestamos inner join estadoPrestamo on prestamos.idestadoPrestamo = estadoPrestamo.idestadoPrestamo inner join libros on prestamos.idLibro = libros.idLibro where prestamos.idestadoPrestamo = 2";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public void AddLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Prestamos (idLibro,clientePrestamo, fechaPrestamo, fechaDevolucionEstimada,idestadoPrestamo) " +
                                      "VALUES (@IdBook, @Customer, @LoanDate,@ReturnEstimatedDate,@IdLoanStatus)";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@IdBook", loan.IdBook);
            _sqlCommand.Parameters.AddWithValue("@Customer", loan.Customer);
            _sqlCommand.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
            _sqlCommand.Parameters.AddWithValue("@ReturnEstimatedDate", loan.ReturnEstimatedDate);
            _sqlCommand.Parameters.AddWithValue("@IdLoanStatus", loan.IdLoanStatus);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void UpdateLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE Prestamos " +
                                      "SET Cliente = @Customer, FechaPrestamo = @LoanDate";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Customer", loan.Customer);
            _sqlCommand.Parameters.AddWithValue("@LoanDate", loan.LoanDate);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void UpdateStatusLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "update prestamos set idestadoPrestamo = @IdLoanStatus where idPrestamo = @IdLoan";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@IdLoanStatus", loan.IdLoanStatus);
            _sqlCommand.Parameters.AddWithValue("@IdLoan", loan.IdLoan);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteLoan(Loan loan)
        {
            try
            {
                _sqlCommand.Connection = _connection.OpenConnection();
                _sqlCommand.CommandText = "DELETE FROM Prestamos WHERE idPrestamo = @Id";
                _sqlCommand.CommandType = CommandType.Text;

                _sqlCommand.Parameters.AddWithValue("@Id", loan.IdLoan);

                _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            finally
            {
                _sqlCommand.Parameters.Clear();
                _connection.CloseConnection();
            }
        }
    }
}
