using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class._Interface
{
    class Book:Product
    {
        public string Genre;
        public Book(int no, string name, double price, string genre) : base(no, name, price)
        {
            Genre = genre;
        }

    }
}
