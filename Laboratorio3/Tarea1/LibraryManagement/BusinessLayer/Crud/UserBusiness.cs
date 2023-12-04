using CommonLayer.Entities;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Crud
{
    public class UserBusiness
    {
        UserData userData = new UserData();
        public DataTable SearchUser(string search)
        {
            DataTable userTable = new DataTable();
            userTable = userData.SearchUser(search);
            return userTable;
        }

        public DataTable GetDataUser(string usuario)
        {
            DataTable userTable = new DataTable();
            userTable = userData.GetDataUser(usuario);
            return userTable;
        }


    }
}
