using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Access_Modifiers._Encapsulation
{
    class Student //a:)Student classimiz var- id,ad ,soyad, ixtisas kimi propertiler
    {
        public int Id;
        public string Name;
        public string SurName;
        public string Speciality;

        public Student(int id,string name,string surName,string speciality)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Speciality = speciality;

        }

    }
}
