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
    public class AuthorData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable booksTable = new DataTable();

        public DataTable GetAllAutores()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT autores.idAutor AS ID, autores.nombre AS Nombre, autores.apellido AS Apellido FROM Autores";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public void AddAuthor(Author author)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Autores(Nombre, Apellido) VALUES(@Nombre, @Apellido)";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Nombre", author.FirstName);
            _sqlCommand.Parameters.AddWithValue("@Apellido", author.LastName);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public DataTable SearchAuthor(string search)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT autores.idAutor AS ID, autores.nombre AS Nombre, autores.apellido AS Apellido FROM autores WHERE nombre LIKE '%' + @search + '%' OR apellido LIKE '%' + @search + '%'";
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Parameters.AddWithValue("@search", search);
            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public void UpdateAuthor(Author author)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE autores "
                                    + "SET nombre = @Nombre, apellido = @Apellido WHERE idAutor = @IdAutor";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Nombre", author.FirstName);
            _sqlCommand.Parameters.AddWithValue("@Apellido", author.LastName);
            _sqlCommand.Parameters.AddWithValue("@IdAutor", author.IdAuthor);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteAuthor(Author author)
        {
            try
            {
                _sqlCommand.Connection = _connection.OpenConnection();
                _sqlCommand.CommandText = "DELETE FROM Autores WHERE idAutor = @IdAutor";
                _sqlCommand.CommandType = CommandType.Text;

                _sqlCommand.Parameters.AddWithValue("@IdAutor", author.IdAuthor);

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
