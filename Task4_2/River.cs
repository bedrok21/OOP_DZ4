using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4_2
{
    internal class River : IGeographicObject
    {
        private double CoordinateX;
        private double CoordinateY;
        private string? Name;
        private string? Description;
        private double StreamSpeed;
        private double RiverLength;
        void IGeographicObject.GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Coordinates: x={0} y={1}", CoordinateX, CoordinateY);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Stream speed: {0}", StreamSpeed);
            Console.WriteLine("River length: {0}", RiverLength);
        }
        void IGeographicObject.SetCoordinateX(double x) => CoordinateX = x;
        void IGeographicObject.SetCoordinateY(double y) => CoordinateY = y;
        void IGeographicObject.SetName(string? name) => Name = name;
        void IGeographicObject.SetDescription(string? description) => Description = description;
        public void SetStreamSpeed(double speed) => StreamSpeed = speed;
        public void SetRiverLength(double length) => RiverLength = length;
    }
}
