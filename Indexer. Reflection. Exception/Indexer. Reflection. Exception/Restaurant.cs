using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer._Reflection._Exception
{
    class Restaurant
    {
        public string Name  { get; set; }
        private Table[] tables;
        public Restaurant(string name, int capacity)
        {
            Name = name;
            tables = new Table[capacity];
        }
        
    }
}
