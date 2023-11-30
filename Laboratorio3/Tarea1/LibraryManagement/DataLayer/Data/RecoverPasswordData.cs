using MailKit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.MailServices;
using CommonLayer.Entities;
using System.Data.Common;

namespace DataLayer.Data
{
    public class RecoverPasswordData
    {
        Connection Connection = new Connection();
        SqlCommand SqlCommand = new SqlCommand();
        SqlDataReader dataReader;

        public string RecoverPassword(User user)
        {
            SqlCommand.Connection = Connection.OpenConnection();
            SqlCommand.CommandText = "SELECT idUsuario, nombre, correo FROM usuarios WHERE correo = @correo";
            SqlCommand.Parameters.AddWithValue("@correo", user.Email);
            SqlCommand.CommandType = CommandType.Text;

            SqlDataReader dataReader = SqlCommand.ExecuteReader();

            if (dataReader.Read() == true)
            {
                int userId = dataReader.GetInt32(0); // Obtener el ID del usuario
                string fullName = dataReader.GetString(1);
                string emailAddress = dataReader.GetString(2);

                Random random = new Random();
                int codigo = random.Next(100000, 999999);

                // Envío de correo
                string content = "Usted está recibiendo este correo electrónico como solicitud de un cambio de contraseña \n" +
                    "Si usted no solicitó el cambio, por favor cambie su contraseña urgentemente por motivos de seguridad \n" +
                    " Su codigo es " + codigo + ". utilice este codigo para modificar su contraseña.\n" +
                    " POE 2023";

                SendMailService mailService = new SendMailService();
                mailService.SendMail("Recuperación de Contraseña", content, emailAddress, fullName);

                // Cerrar el DataReader
                dataReader.Close();
                SqlCommand.Parameters.Clear();
                Connection.CloseConnection();

                // Insertar el código de recuperación
                InsertRecoveryCode(userId, codigo.ToString());

                return "Se ha enviado su contraseña a su correo, \n por favor verifique iniciando sesión.";
            }
            else
            {
                // Cerrar el DataReader
                dataReader.Close();
                SqlCommand.Parameters.Clear();
                Connection.CloseConnection();

                return "No se ha podido enviar el correo electrónico";
            }
        }

        public void InsertRecoveryCode(int userId, string recoveryCode)
        {
            SqlCommand.Connection = Connection.OpenConnection();
            SqlCommand.CommandText = "INSERT INTO CodigosRecuperacion (idUsuario, Codigo, Estado) VALUES (@idUsuario, @codigo, 0)";
            SqlCommand.Parameters.AddWithValue("@idUsuario", userId);
            SqlCommand.Parameters.AddWithValue("@codigo", recoveryCode);
            SqlCommand.ExecuteNonQuery();
            SqlCommand.Parameters.Clear();
            Connection.CloseConnection();
        }

        public bool ChangePasswordAndDeleteCode(User user, CodeRecover codeRecover)
        {
            SqlCommand.Connection = Connection.OpenConnection();
            SqlCommand command = new SqlCommand("ActualizarContraseñaPorCodigo", SqlCommand.Connection);
            command.CommandType = CommandType.StoredProcedure;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
            
            command.Parameters.Add("@codigo", SqlDbType.NVarChar, 50).Value = codeRecover.Code;
            command.Parameters.Add("@nuevaContraseña", SqlDbType.NVarChar, 100).Value = hashedPassword;

            SqlDataReader reader = command.ExecuteReader();

            bool success = false;
            if (reader.HasRows)
            {
                reader.Close();
                SqlCommand.Connection.Close();
                success = true;
            }
            else
            {
                reader.Close();
                SqlCommand.Connection.Close();
            }

            return success;
        }



        public bool VerifiedPasswordCode(CodeRecover codeRecover)
        {
            SqlCommand.Connection = Connection.OpenConnection();
            SqlCommand.CommandText = "select * from CodigosRecuperacion WHERE Codigo = @code and Estado = 0";            
            SqlCommand.Parameters.AddWithValue("@code", codeRecover.Code);
            SqlCommand.CommandType = CommandType.Text;

            dataReader = SqlCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Close();
                dataReader.Dispose();
                Connection.CloseConnection();

                return true;
            }
            else
            {
                return false;
            }


        }
    }
    }

