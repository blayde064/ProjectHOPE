using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHOPE
{
    public class User
    {
        public string Username { get; set; }
        public string UserType { get; set; }
        public string WorkType { get; set; }

        public static User AttemptLogin(string username, string password)
        {
            if(username == "user")
            {
                return new User() { Username = "user", UserType = "user", WorkType = "production" };
            }

            else if (username == "admin" && password == "admin")
            {
                return new User() { Username = "admin", UserType = "admin", WorkType = "admin" };
            }

            return null;
        }
    }
}
