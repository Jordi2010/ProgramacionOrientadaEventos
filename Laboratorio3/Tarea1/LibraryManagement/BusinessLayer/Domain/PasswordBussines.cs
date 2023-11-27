using CommonLayer.Entities;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Domain
{
    public class PasswordBussines
    {
        RecoverPasswordData recoverPassword = new RecoverPasswordData();

        public string RecoverPassword(User user)
        {
            return recoverPassword.RecoverPassword(user);
        }
    }
}
