using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MyLibs
{
    internal class User
    {
        string name;
        string surname;
        string DateBurn;
        
        public User(string n, string sn, string db)
        {
            name = n; 
            surname = sn;
            db = DateBurn;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetDateBurn()
        {
            return   DateBurn; 
        }
    }
}
