using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    internal interface IGeographicObject
    {
        void GetInfo();
        void SetCoordinateX(double x);
        void SetCoordinateY(double y);
        void SetName(string? name);
        void SetDescription(string? description);
    }
}
