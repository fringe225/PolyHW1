using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyHW1
{
    internal class User : IAccount
    {

        public string FullName;
        public string Email;
        private string _password;


        public User(string name,string email,string password)
        {
            FullName = name;
            Email = email;
            Password = password;
        }

        public string Password
        {
            get { return _password; }
            set 
            {
                while (!PasswordChecker(value))
                {
                    Console.WriteLine("Enter Password Right: ");
                    value = Console.ReadLine()??" ";
                }
                _password = value;
            }
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length >= 8)
            {
                bool CheckUpper = false;
                bool CheckLower = false;
                bool CheckDigit = false;

                foreach (var item in password)
                {
                    if (char.IsDigit(item))
                    {
                        CheckDigit = true;

                    }
                    else if (char.IsUpper(item))
                    {
                        CheckUpper = true;
                    }
                    else if (char.IsLower(item))
                    {
                        CheckLower = true;
                    }
                }
                if (CheckLower && CheckUpper && CheckDigit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
            { 
                return false;
            }
           

            

            
        }

        public void ShowInfo()
        {
            Console.Write($"Name - {FullName}\nEmail - {Email}\n");
        }
    }
}
