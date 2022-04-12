using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consolehomework
{
    class User
    {

        public string _userName;
        public string _password;
        int minLength = 8;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value.Length >= minLength)
                {
                    _userName = value;
                    return;
                }
                Console.WriteLine("Yeniden Username daxil edin");
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length >= minLength)
                {
                    _password = value;
                    return;
                }
                Console.WriteLine("Passwordu yeniden daxil edin");
                if (!Password.Any(char.IsDigit))
                {
                    return;
                }
                if (!Password.Any(char.IsUpper))
                {
                    return;
                }
                if (!Password.Any(char.IsLower))
                {
                    return;
                }
            }
        }

        public User(string username, string password)
        {
            username = UserName;
            password = Password;
        }
    }
}
     