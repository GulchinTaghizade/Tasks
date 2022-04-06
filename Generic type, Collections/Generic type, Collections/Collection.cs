using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_type__Collections 
{
    // Bir collection yaradırsız, içərisinə proqramlaşdırma dillərini və yaradıldığı tarixləri daxil edirsiz.
    //İlk olaraq proqramlaşdırma dilləri ilə (yeni yarandighi tarixe gore) görə, sonra isə adlarına görə sıralansın
    class Collection<T> where T:ProgLang
    {
        public T[] Languages;

        public IEnumerable<ProgLang> Language { get; internal set; }

        public Collection()
        {
            Languages = new T[0];
        }

        public void AddLanguage(T lang)
        {
            Array.Resize(ref Languages, Languages.Length + 1);
            Languages[Languages.Length - 1] = lang;
        }
        public void NameSort( )
        {
            for (int i = 0; i < Languages.Length; i++)
            {
                for (int j = i + 1; j < Languages.Length; j++)
                {
                    Array.Sort(Languages, (x, y) => String.Compare(x.LangName, y.LangName));
                }
            }

        }
        public void DateSort()
        {
            DateTime temp = new DateTime();
            for (int i = 0; i < Languages.Length; i++)
            {
                for (int j = i+1; j < Languages.Length; j++)
                {
                    if (Languages[i].LangDate>Languages[j].LangDate)
                    {
                        temp = Languages[i].LangDate;
                        Languages[i].LangDate = Languages[j].LangDate;
                        Languages[j].LangDate = temp;

                    }
                }

            }
        }
       

    }
}
