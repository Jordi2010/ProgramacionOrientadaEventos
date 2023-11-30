using CommonLayer.Entities;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class AuthData
    {
        Connection _connection = new Connection();
        SqlCommand _sqlCommand = new SqlCommand();
        SqlDataReader _readerRows;

        public bool Login(User user)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT * FROM usuarios WHERE usuario = @user AND contraseña = @password;";
            _sqlCommand.Parameters.AddWithValue("@user", user.UserName);
            _sqlCommand.Parameters.AddWithValue("@password", user.Password);
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();

            if (_readerRows.HasRows)
            {
                _readerRows.Close();
                _readerRows.Dispose();
                _connection.CloseConnection();

                return true;
            }
            else
            {
                return false;
            }
        }

        public int Register(string firstName, string lastName, string email, string password)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Users " +
                " VALUES(@firstName, @lastName, @email, @password)";

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            _sqlCommand.Parameters.AddWithValue("@firstName", firstName);
            _sqlCommand.Parameters.AddWithValue("@lastName", lastName);
            _sqlCommand.Parameters.AddWithValue("@email", email);
            SqlParameter sqlParameter = _sqlCommand.Parameters.AddWithValue("@password", hashedPassword);
            _sqlCommand.CommandType = CommandType.Text;

            var rowsAffected = _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();

            return rowsAffected;
        }

        public string GetPasswordByUserName(User user)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT * FROM usuarios WHERE usuario = @usuario;";
            _sqlCommand.Parameters.AddWithValue("@usuario", user.UserName);
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();

            string password = "";

            if (_readerRows.Read() == true)
            {
                try
                {
                    password = _readerRows.GetString(2);
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }
            }

            _readerRows.Close();
            _readerRows.Dispose();
            _connection.CloseConnection();

            return password;
        }

        public int Register(User user)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO usuarios (usuario, contraseña, nombre, apellido, correo, telefono, fechaCreacion) " +
                "VALUES(@usuario, @contraseña, @nombre, @apellido, @correo, @telefono, GETDATE())"; 

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);

            _sqlCommand.Parameters.AddWithValue("@usuario", user.UserName);
            _sqlCommand.Parameters.AddWithValue("@contraseña", hashedPassword);
            _sqlCommand.Parameters.AddWithValue("@nombre", user.Name);
            _sqlCommand.Parameters.AddWithValue("@apellido", user.LastName);
            _sqlCommand.Parameters.AddWithValue("@correo", user.Email);
            _sqlCommand.Parameters.AddWithValue("@telefono", user.Phone);
            _sqlCommand.CommandType = CommandType.Text;

            var rowsAffected = _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();

            return rowsAffected;
        }



    }
}
