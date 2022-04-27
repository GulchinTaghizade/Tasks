using EntityFramework.AccessDB;
using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework.Controller
{
    public class AppController
    {
        private readonly AppDBContext _context;

        public AppController()
        {
            _context = new AppDBContext();
        }

        public void GetEmployeeById(int? id)
        {
            try
            {
                Employee emp1 = _context.Employees.Find(id);
                Console.WriteLine(emp1.FullName);

            }
            catch (Exception)
            {
                Console.WriteLine("Entered ID is not exist or NULL!!");
            }

        }

        public void GetAllEmployees()
        {
            List<Employee> newlist = _context.Employees.ToList();
            foreach (var item in newlist)
            {
                Console.WriteLine(item.Id + " " + item.FullName);
            }

        }

        public void AddEmployee(string fullname)
        {
            if (fullname != null)
            {
                Employee newEmp = new Employee { FullName = fullname };
                _context.Employees.Add(newEmp);
                _context.SaveChanges();
                Console.WriteLine($"{newEmp.FullName} successfully added to Employees table");
            }
            else
            {
                Console.WriteLine("FullName can not be NULL!!!");
            }



        }

        public void DeleteEmployee(int? id)
        {
            try
            {
                if (id != null)
                {
                    Employee deletedEmp = _context.Employees.Find(id);
                    _context.Employees.Remove(deletedEmp);
                    _context.SaveChanges();
                    Console.WriteLine($"{deletedEmp.Id}th data was successfully deleted from Employees table");

                }
                else
                {
                    Console.WriteLine("Null Id can not be entered!!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Entered ID is not exist in Employee table");
            }
           
        }

        public void FilterByName(string search)
        {
            List<Employee> EmpList = _context.Employees.ToList();
            bool isExist = false;
            foreach (var item in EmpList)
            {
                if (item.FullName.ToLower().Contains(search) || item.FullName.ToUpper().Contains(search))
                {
                    Console.WriteLine(item.FullName);
                    isExist = true;
                }
            }
            if (!isExist)
            {
                Console.WriteLine($"{search} is not contain in any Employee's FullName");
            }
        }
    }
}
