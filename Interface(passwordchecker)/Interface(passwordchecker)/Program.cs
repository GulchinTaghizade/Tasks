using System;

namespace Interface_passwordchecker_
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr1 = new User("Gulchinnl","gulchin.tagizade@gmail.com");
            usr1.Password = "Taghizada777";
            usr1.PasswordChecker(usr1.Password);
            usr1.Showinfo();
            


        }


    }
}
