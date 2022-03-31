using System;

namespace Tasks.Access_Modifiers._Encapsulation
{
    class Group //b:)Group classimiz var- name, maxStuCount ve students array-i (hansi ki telebeleri saxlayacaq)
    {

        public string GroupName;
        public int MaxStuCount;

        public Group(int maxStuCount)
        {
            MaxStuCount = maxStuCount;
        }

        public Student[] Students = new Student[] { };

        //c;)Group-un AddStudent() ve RemoveStudent() metodlari yazilmalidir

        public void AddStudent(Student stu1)
        {
            if (Students.Length + 1 <= MaxStuCount)
            {
                Student[] newStudents = new Student[Students.Length + 1];
                for (int i = 0; i < Students.Length; i++)
                {
                    newStudents[i] = Students[i];
                }
                newStudents[newStudents.Length - 1] = stu1;
                Students = newStudents;
                Console.WriteLine(Students[Students.Length-1].Name);
            }
            else
            {
                Console.WriteLine("This group is full.It is impossible to add new student to this group!!!");
            }

        }

        public void RemoveStudent(Student student)
        {
            Student[] newStudents = new Student[Students.Length-1];
            
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i]==student)
                {
                    continue;
                   
                }
                else
                {
                    newStudents[i] = Students[i];
                }    
            }
           
            Students = newStudents;

        }



    }
}
