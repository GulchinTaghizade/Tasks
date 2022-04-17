using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public bool Type { get; set; }

        public Student()
        {
            Console.WriteLine("Student's FullName: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Student's Group No: ");
            GroupNo = Console.ReadLine();
            Console.WriteLine("Student's Type (zemanetli/zemanetsiz): ");
            Type = Convert.ToBoolean(Console.ReadLine());
            
        }

        public override string ToString()
        {
            var result = Type ? "Zemanetli" : "Zemanetsiz";
            return $"Fullname: {FullName} GroupNo:{GroupNo} Type: {result}";
        }

    }
}
