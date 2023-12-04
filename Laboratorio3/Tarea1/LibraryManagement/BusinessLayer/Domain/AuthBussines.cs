using CommonLayer.Entities;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Domain
{
    public class AuthBussines
    {
        AuthData authData = new AuthData();
        public bool LoginUser(User user)
        {
            return authData.Login(user);
        }

        public string GetPasswordByUserName(User user)
        {
            return authData.GetPasswordByUserName(user);
        }

        public int RegisterUser(User user)
        {
            return authData.Register(user);
        }
        
    }
}
