using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Febsec7Prj
{
    public class Bank
    {
        public string Authenticate(string UserName, string UserId)
        {
            string msg;
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(UserId))
            {
                msg = "user name and password required ";
            }
            else
            {
                if ((UserName == "Ram") && (UserId == "ram1234"))
                {
                    msg = "Authentication pass";
                }
                else
                {
                    msg = "Authentcation fail";
                }
            }
            return "provide user details";

        }
    }
}

