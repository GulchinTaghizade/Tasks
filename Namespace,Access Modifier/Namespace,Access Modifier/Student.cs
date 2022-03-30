using System;


namespace Namespace_Access_Modifier
{
    class Student
    {

        public int Id { get; }
        public static int _id;
        public string Name;
        public string SurName;
        public int Age;
        public double Point;
        public Student(string name, string surname, int age, double point)
        {
            if (name != " " || surname != " " || point != null)
            {
                Name = name;
                SurName = surname;
                Age = age;
                Point = point;
                _id++;
                Id = _id;

            }
            else
            {
                Console.WriteLine("Name, surname, point deyerleri olmadan student obyekti yaratmaq olmaz");
            }

        }


        public string ShowInfo()
        {

            return $"ID:{Id}\nName: {Name}\nSurname: {SurName}\nAge: {Age}\nPoint: {Point}\n";
        }

    }

}
