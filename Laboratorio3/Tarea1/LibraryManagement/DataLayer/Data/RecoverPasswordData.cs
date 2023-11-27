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
            SqlCommand.CommandText = "SELECT idUsuario, nombre, correo, contraseña FROM usuarios WHERE correo = @correo";
            SqlCommand.Parameters.AddWithValue("correo", user.Email);
            SqlCommand.CommandType = CommandType.Text;

            dataReader = SqlCommand.ExecuteReader();

            if (dataReader.Read() == true)
            {
                string fullName = dataReader.GetString(1);
                string emailAddress = dataReader.GetString(2);
                string password = dataReader.GetString(3);

                string content = "Usted esta recibiendo este correo electronico como solicitud de un cambio de contraseña \n" +
                    "Si usted no solicito el cambio por favor cambie su contraseña urgentemente por motivos de seguridad \n" +
                    " Su contraseña actual es " + password + " por favor, cambiela por otra al iniciar sesión.\n" +
                    " POE 2023";

                SendMailService mailService = new SendMailService();
                mailService.SendMail("Recuperación de Contraseña", content, emailAddress, fullName);

                return "Se ha enviado su contraseña a su correo, \n por favor verifique iniciando sesión.";
            }
            else
            {
                return "No se ha podido enviar el email";
            }
        }
    }
}
