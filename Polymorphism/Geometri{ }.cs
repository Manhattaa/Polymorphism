using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Geometri
    {
        public virtual string ShapeName()
        {
            return "Unknown Shape";
        }
        public virtual double Area()
        {
            return 0.0;
        }

    }
}
