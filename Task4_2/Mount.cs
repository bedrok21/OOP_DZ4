using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    internal class Mount : IGeographicObject
    {
        private double CoordinateX;
        private double CoordinateY;
        private string? Name;
        private string? Description;
        private double HighestPoint;
        void IGeographicObject.GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Coordinates: x={0} y={1}", CoordinateX, CoordinateY);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Highest point: {0}", HighestPoint);
        }
        void IGeographicObject.SetCoordinateX(double x)=>CoordinateX = x;
        void IGeographicObject.SetCoordinateY(double y)=>CoordinateY = y;
        void IGeographicObject.SetName(string? name) => Name = name;
        void IGeographicObject.SetDescription(string? description) => Description = description; 
        public void SetHighestPoint(double point) => HighestPoint = point;
    }
}
