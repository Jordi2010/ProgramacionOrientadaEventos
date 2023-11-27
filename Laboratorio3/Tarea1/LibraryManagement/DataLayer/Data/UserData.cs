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
    public class UserData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable statusTable = new DataTable();

        public DataTable ValidateUser(User user)
        {
            DataTable userData = new DataTable();

            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT * FROM usuarios WHERE usuario = @Usuario AND contraseña = @password";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Usuario", user.UserName);
            _sqlCommand.Parameters.AddWithValue("@password", user.Password);
            _readerRows = _sqlCommand.ExecuteReader();
            userData.Load(_readerRows);

            _connection.CloseConnection();

            return userData;
        }


        public void AddUser(Author author)
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
    }
}