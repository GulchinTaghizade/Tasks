using EntityFramework.Controller;
using EntityFramework.Models;
using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1.Get All Employee\n" +
                    "2.Get Employee By ID\n" +
                    "3.Add New Employee\n" +
                    "4.Delete Employee By ID\n" +
                    "5.Filter Employee By Name\n");
                Console.Write("Please choose one of the menu's statement: ");
                int choice=int.Parse(Console.ReadLine());
                AppController emp1 = new AppController();
                switch (choice)
                {
                    case 1:
                    emp1.GetAllEmployees();
                        break;
                    case 2:
                        Console.WriteLine("Please enter ID");
                        int id = int.Parse(Console.ReadLine());
                        emp1.GetEmployeeById(id);
                        break;
                    case 3:
                        Console.WriteLine("Please enter New Employee's FullName");
                        string fullname =Console.ReadLine();
                        emp1.AddEmployee(fullname);
                        break;
                    case 4:
                        Console.WriteLine("Please enter ID");
                        int Id = int.Parse(Console.ReadLine());
                        emp1.DeleteEmployee(Id);
                        break;
                    case 5:
                        Console.WriteLine("Please enter search value");
                        string search = Console.ReadLine();
                        emp1.FilterByName(search);
                        break;
                    default:
                        Console.WriteLine("Please Enter correct value!");
                        break;
                }

            }
            
        }
    }
}
