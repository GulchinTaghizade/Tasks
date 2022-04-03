using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_passwordchecker_
{
    class User:IAccaunt
    {
        public string FullName;
        public string Email;
        public string Password;

        public User(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
            
        }

        bool IsUpper;
        bool IsLower;
        bool IsDigit;
        public bool PasswordChecker(string password)  
        {
            if (password.Length>=8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]))
                    {
                        IsUpper = true;
                       
                    }

                    if (Char.IsLower(password[i]))
                    {
                        IsLower = true;
                      
                    }

                    if (Char.IsDigit(password[i]))
                    {
                        IsDigit = true;
                      
                    }

                }
            }
            if (IsUpper && IsLower && IsDigit)
            {
                Password = password;
                Console.WriteLine("Password created!");
                return true;
            }
            else
            {
                Console.WriteLine("This password can not be assigned!!");
            }
            return false;
        }

        public void Showinfo()
        {
            Console.WriteLine($"Fullname: {FullName}\nEmail: {Email}");
        }

        
    }
}
