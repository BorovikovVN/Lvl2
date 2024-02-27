using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvl2
{
    internal class User
    {
       
        public User(String login, String password, bool isadmin)
        {
            UserLogin = login;
            UserPassword = password;
            IsAdmin = isadmin;
        }
        public bool IsAdmin { get; set; }
        public String UserLogin { get; private set; }
        public String UserPassword { get; private set;}
    }
}
