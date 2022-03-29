using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Access_Modifiers._Encapsulation
{
    class Student //a:)Student classimiz var- id,ad ,soyad, ixtisas kimi propertiler
    {

        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string Surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        public string Speciality
        {
            get
            {
                return Speciality;
            }
            set
            {
                Speciality=value;
            }
        }


        

    }
}
