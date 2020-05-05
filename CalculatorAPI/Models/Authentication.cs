using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorAPI.Models
{
    public class Authentication
    {
        public static bool Verify(string username, string password)
        {
            if (username == "Ayyappa" && password == "Ayyappa97")
            {
                return true;
            }
            else
                return false;
        }
    }
}