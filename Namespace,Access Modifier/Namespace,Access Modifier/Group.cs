using System;

namespace Namespace_Access_Modifier
{
    class Group
    {
        public int No { get; }
        public static int _no = 200;

        public Group()
        {
            _no++;
            No = _no;
        }

        public void info()
        {
            Console.WriteLine($"Group no: BP{No}");
        }

        Student[] students=new Student[] { };

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }

        public Student[] Sort()
        {
            Student temp;
           
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i+1; j < students.Length; j++)
                {
                    if (students[i].Point>students[j].Point)
                    {
                        temp=students[i];
                        students[i]=students[j];
                        students[j] = temp;

                    }

                }
            }

            return students;

        }


    }
}
