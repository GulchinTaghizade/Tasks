using Indexer._Reflection._Exception.Models;
using Indexer._Reflection._Exception.Utilities;
using System;

namespace Indexer._Reflection._Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Send message by Email\n2.Send message by SMS\n0.Quit");
            int choice = Int32.Parse(Console.ReadLine());
            EmailSender byemail = new EmailSender();
            SmsSender bysms = new SmsSender();

            switch (choice)
            {
                case 1:
                    byemail.SendMessage();
                    break;
                case 2:
                    bysms.SendMessage();
                    break;
                case 3:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }




        }
    }
}
