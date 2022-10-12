using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Book : Commodity
    {
        public int Pages { set; get; }
        public string? Publisher { set; get; }
        public string? Authors { set; get; }

        public Book(string? name, double price, string? description, string? originCountry, string? packagingDate) 
            : base(name, price, description, originCountry, packagingDate)
        {
        }
        public Book() { }
    }
}
