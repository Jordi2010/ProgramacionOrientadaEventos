﻿using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class BookData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable booksTable = new DataTable();

        public DataTable GetAllBook()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT libros.idLibro AS ID, libros.editorialLibro AS Editorial, libros.nombreLibro AS Libro, libros.isbnLibro AS ISBN, " +
                   "libros.generoLibro AS Género, CONCAT(autores.nombre, ' ', autores.apellido) AS Autor, estadoLibro.estadoLibro AS Estado, libros.idAutor, libros.idestadoLibro " +
                   "FROM libros INNER JOIN autores ON libros.idAutor = autores.idAutor " +
                   "INNER JOIN estadoLibro ON libros.idestadoLibro = estadoLibro.idestadoLibro";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public DataTable SearchBook(string search)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT libros.idLibro AS ID, libros.nombreLibro AS Libro, libros.editorialLibro AS Editorial, libros.isbnLibro AS ISBN, libros.generoLibro AS Género, CONCAT(autores.nombre, ' ', autores.apellido) AS Autor, estadoLibro.estadoLibro AS Estado, libros.idAutor, libros.idestadoLibro FROM libros INNER JOIN autores ON libros.idAutor = autores.idAutor INNER JOIN estadoLibro ON libros.idestadoLibro = estadoLibro.idestadoLibro WHERE nombreLibro LIKE '%' + @search + '%'";
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Parameters.AddWithValue("@search", search);
            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public DataTable getFilterBook()
        {
            DataTable bookFilterTable = new DataTable();
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT libros.idLibro, libros.nombreLibro, autores.nombre, autores.apellido " +
                          "FROM libros " +
                          "INNER JOIN autores ON libros.idAutor = autores.idAutor " +
                          "WHERE libros.idestadoLibro = 1";
            _sqlCommand.CommandType = CommandType.Text;
            _readerRows = _sqlCommand.ExecuteReader();
            bookFilterTable.Load(_readerRows);
            _sqlCommand.Connection = _connection.CloseConnection();

            return bookFilterTable;
        }

        public void AddBook(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO libros (editorialLibro, nombreLibro, isbnLibro, generoLibro, idAutor, idestadoLibro) " +
                                      "VALUES ( @Publisher, @Title, @Isbn, @Genre, @idAutor,@idestadoLibro)";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Publisher", book.Publisher);
            _sqlCommand.Parameters.AddWithValue("@Title", book.Title);
            _sqlCommand.Parameters.AddWithValue("@Isbn", book.Isbn);
            _sqlCommand.Parameters.AddWithValue("@Genre", book.Genre);

            _sqlCommand.Parameters.AddWithValue("@idAutor", book.IdAuthor);
            _sqlCommand.Parameters.AddWithValue("@idestadoLibro", book.IdStatus);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void UpdateBook(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE libros SET editorialLibro = @Publisher, nombreLibro = @Title, isbnLibro = @Isbn, generoLibro = @Genre, idAutor = @IdAuthor, idestadoLibro = @IdStatus WHERE idLibro = @IdBook";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Publisher", book.Publisher);
            _sqlCommand.Parameters.AddWithValue("@Title", book.Title);
            _sqlCommand.Parameters.AddWithValue("@Isbn", book.Isbn);
            _sqlCommand.Parameters.AddWithValue("@Genre", book.Genre);
            _sqlCommand.Parameters.AddWithValue("@IdAuthor", book.IdAuthor);
            _sqlCommand.Parameters.AddWithValue("@IdStatus", book.IdStatus);
            _sqlCommand.Parameters.AddWithValue("@IdBook", book.IdBook);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }
        public void UpdateBookStatus(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE libros SET  idestadoLibro = @IdStatus WHERE idLibro = @IdBook";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@IdStatus", book.IdStatus);
            _sqlCommand.Parameters.AddWithValue("@IdBook", book.IdBook);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteBook(Book book)
        {
            try
            {
                _sqlCommand.Connection = _connection.OpenConnection();
                _sqlCommand.CommandText = "DELETE FROM Libros WHERE idLibro = @Id";
                _sqlCommand.CommandType = CommandType.Text;

                _sqlCommand.Parameters.AddWithValue("@Id", book.IdBook);
                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                string errorMessage = ex.Message;
            }
            finally
            {
                _sqlCommand.Parameters.Clear();
                _connection.CloseConnection();
            }
        }
    }
}
