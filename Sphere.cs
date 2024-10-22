using Labaa6_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    class Sphere : ISolid
    {
        public double R { get; set; }

        public Sphere(double r)
        {
            R = r;
        }

        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
        }
    }
}
