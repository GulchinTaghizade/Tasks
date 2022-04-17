using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class Group
    {
        public  string No { get; set; }
        public string Category { get; set; }

        public bool IsOnline { get; set; }

        public int Limit { get; set; }

        public List<Student> students { get; set; }

        public Group()
        {
            Console.WriteLine("Group No: ");
            No = Console.ReadLine();
            if (No==null || No==" " || No=="")
            {
                Console.WriteLine("Please insert correctly!!");
                Console.WriteLine("Group No: ");
                No = Console.ReadLine();
            }
            

            Console.WriteLine("Group Category: ");
            Category = Console.ReadLine();
            if (Category.ToLower() != "programming" && Category.ToLower() != "design" && Category.ToLower() != "system administration")
            {
                Console.WriteLine("This category does not exist!!");
                Console.WriteLine("Group Category: ");
                Category = Console.ReadLine();

            }
            Console.WriteLine("Group IsOnline (true/false): ");
            IsOnline = Convert.ToBoolean(Console.ReadLine());
         
            if (IsOnline == true)
            {
                IsOnline = true;
                Limit = 15;

            }
            else
            {
                Limit = 10;

            }
            Console.WriteLine($" Group {No} created ");

        }
        
        
    }
}
