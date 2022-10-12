using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Product : Commodity
    {
        public double Amount { set; get; }
        public string? MesureUnit { set; get; }
        public string? ExpiryDate { set; get; }

        public Product(string? name, double price, string? description, string? originCountry, string? packagingDate) 
            : base(name, price, description, originCountry, packagingDate)
        {
        }
        public Product() { }
    }
}
