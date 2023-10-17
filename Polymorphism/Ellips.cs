using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Ellips : Geometri
    {
        public double LargeAxis { get; set; }
        public double LilAxis { get; set; }

        public Ellips() 
        {
            LargeAxis= 0;
            LilAxis= 0;
        }
        public override string ShapeName()
        {
            return "Ellips";
        }

        public override double Area()
        {
            return Math.PI * LargeAxis * LilAxis;   
        }
    }
}
