using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    internal class River : GeographicObject
    {
        private double StreamSpeed;
        private double RiverLength;
        public River(double coordinateX, double coordinateY, string name, string description, double streamSpeed, double riverLenght) 
            : base(coordinateX, coordinateY, name, description)
        {
            StreamSpeed = streamSpeed;
            RiverLength = riverLenght;
        }
        public River() { }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Stream speed: {0}", StreamSpeed);
            Console.WriteLine("Length: {0}", RiverLength);
        }
        public void SetStreamSpeed(double streamSpeed) => StreamSpeed = streamSpeed;
        public void SetRiverLength(double riverLength) => RiverLength = riverLength;
    }
}
