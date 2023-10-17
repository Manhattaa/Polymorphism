using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rektangel : Geometri
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rektangel()
        {
            Length = 0;
            Width = 0;
        }
        public override string ShapeName()
        {
            return "Rektangel";
        }
        public override double Area()
        {
            return Length * Width;
        }
    }
}
