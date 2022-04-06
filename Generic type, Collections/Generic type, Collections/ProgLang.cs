using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type__Collections
{
    class ProgLang
    {
        public string LangName { get; set; }
        public DateTime LangDate { get; set; }
        public ProgLang(string langName, DateTime langDate)
        {
            LangName = langName;
            LangDate = langDate;
                
        }
    }
}
