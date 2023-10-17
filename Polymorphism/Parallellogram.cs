using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Parallellogram : Geometri
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Parallellogram() 
        {
            Base= 0;
            Height= 0;
        }

        public override string ShapeName()
        {
            return "Parallellogram";
        }

        public override double Area()
        {
            return Base * Height;
        }
    }
}
