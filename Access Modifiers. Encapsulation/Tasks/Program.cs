using System;
using Tasks.Access_Modifiers._Encapsulation;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(77, "Gulchin", "Taghizade", "CS");

            Group gr1 = new Group();
            gr1.AddStudent(student1);


        }
    }
}
