using System;
using Tasks.Access_Modifiers._Encapsulation;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(77, "Gulchin", "Taghizade", "CS");
            Student student2 = new Student(78, "Ilaha", "Taghizade", "Finance");
            Student student3 = new Student(78, "Abbas", "Taghizade", "Finance");



            Group gr1 = new Group(4);

            gr1.AddStudent(student1);
            gr1.AddStudent(student2);
            gr1.AddStudent(student3);



        }
    }
}
