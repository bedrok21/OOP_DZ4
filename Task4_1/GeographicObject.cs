using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    internal abstract class GeographicObject
    {
        protected double CoordinateX;
        protected double CoordinateY;
        protected string? Name;
        protected string? Description; 
        public GeographicObject(double coordinateX, double coordinateY, string name, string description)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Name = name;
            Description = description;
        }
        public GeographicObject() { }
        public virtual void GetInfo() 
        {
            Console.WriteLine();
            Console.WriteLine("Coordinates: x={0} y={1}", CoordinateX, CoordinateY);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
        }
        public void SetName(string? name) => Name = name;
        public void SetDescription(string? description) => Description = description;
        public void SetCoordinateX(double x) => CoordinateX = x;
        public void SetCoordinateY(double y) => CoordinateY = y;
    }
}
