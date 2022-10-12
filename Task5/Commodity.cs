using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Commodity
    {
        public string? Name { set; get; }
        public double Price { set; get; }
        public string? Description { set; get; }
        public string? OriginCountry { set; get; }
        public string? PackagingDate { set; get; }
        public Commodity(string? name, double price, string? description, string? originCountry, string? packagingDate)
        {
            Name = name;
            Price = price;
            Description = description;
            OriginCountry = originCountry;
            PackagingDate = packagingDate;
        }
        public Commodity() { }
    }
}
