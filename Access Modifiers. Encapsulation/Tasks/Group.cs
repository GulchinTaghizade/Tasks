using System;

namespace Tasks.Access_Modifiers._Encapsulation
{
    class Group //b:)Group classimiz var- name, maxStuCount ve students array-i (hansi ki telebeleri saxlayacaq)
    {
        public string GroupName {
            get 
            {
                return GroupName;
            } 
            set
            {
                GroupName = value;
            }
        }

        public int MaxStuCount
        {
            get
            {
                return MaxStuCount;
            }
            set
            {
                MaxStuCount = value;
            }
        }

        public Student[] Students = new Student[] { };

        //c;)Group-un AddStudent() ve RemoveStudent() metodlari yazilmalidir

        public void AddStudent(Student stu1)
        {
            if (Students.Length+1>MaxStuCount)
            {
                Student[] newStudents = new Student[Students.Length + 1];
                for (int i = 0; i < Students.Length; i++)
                {
                    newStudents[i] = Students[i];
                }
                newStudents[newStudents.Length - 1] = stu1;
                Students = newStudents;
                Console.WriteLine(Students[0].Name);

            }
            else
            {
                Console.WriteLine("This group is full.It is impossible to add new student to this group!!!");
            }
            
        }

        public void RemoveStudent(int id)
        {
            Student[] newStudents = new Student[Students.Length-1];
            int targetIndex = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (id != Students[i].Id)
                {
                    newStudents[i] = Students[i];
                    targetIndex++;
                }
                else
                {
                    return;
                }    
            }
            for (int j =targetIndex; j < Students.Length; j++)
            {
                newStudents[j] = Students[j+1];

            }
            Students = newStudents;

        }



    }
}
