using System;


namespace Generic_type__Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime PythonDate = new DateTime(1991, 02, 20);
            ProgLang Python = new ProgLang("Python", PythonDate);

            DateTime JavaDate = new DateTime(1996, 01, 23);
            ProgLang Java = new ProgLang("Java", JavaDate);

            DateTime JavaScriptDate = new DateTime(1995, 12, 04);
            ProgLang JavaScript = new ProgLang("JavaScript", JavaScriptDate);

            Collection<ProgLang> Languages = new Collection<ProgLang>();
            Languages.AddLanguage(Python);
            Languages.AddLanguage(Java);
            Languages.AddLanguage(JavaScript);
          

            //Languages.DateSort();
            //Languages.NameSort();

            foreach (ProgLang item in Languages.Languages)
            {
                Console.WriteLine($"{item.LangName}\n{item.LangDate}\n");
            }

        }
    }
}
