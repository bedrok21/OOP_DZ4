using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    internal class Mount:GeographicObject
    {
        private double HighestPoint;

        public Mount(double coordinateX, double coordinateY, string name, string description, double highestPoint) 
            : base(coordinateX, coordinateY, name, description)
        {
            HighestPoint = highestPoint;
        }
        public Mount() { }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Highest point: ", HighestPoint);
        }
        public void SetHighestPoint(double highestPoint) => HighestPoint = highestPoint;
    }
}
