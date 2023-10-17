using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double Side { get; set; }

        public Fyrkant() 
        {
            Side = 0;
        }

        public override string ShapeName()
        {
            return "Fyrkant";
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
