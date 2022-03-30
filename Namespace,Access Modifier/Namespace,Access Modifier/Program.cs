using System;

namespace Namespace_Access_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Gulchin", "Taghizade", 20, 97.73);
            //Console.WriteLine(stu1.ShowInfo());


            Student stu2 = new Student("Ilahe", "Taghizade", 19, 100);
            Student stu3 = new Student("Karim", "Aliyev", 19, 55);

            //Console.WriteLine(stu2.ShowInfo());

            Group gr1 = new Group();
            //gr1.info();
            gr1.AddStudent(stu1);
            gr1.AddStudent(stu2);
            gr1.AddStudent(stu3);
            gr1.GetAllStudents();
            gr1.Sort();

        }
    }
}
