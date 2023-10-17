using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cirkel : Geometri
    {
        public double Radie { get; set; }

        public Cirkel() 
        {
            Radie = 0;
        }

        public override string ShapeName()
        {
            return "Cirkel";
        }

        public override double Area()
        {
            return Math.PI* Radie * Radie;
        }
    }
}
