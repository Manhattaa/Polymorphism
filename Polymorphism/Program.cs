using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            Geometri[] geometriskaObjekt = new Geometri[]
            {
            new Rektangel { Length = 5, Width = 3 },
            new Fyrkant { Side = 4 },
            new Cirkel { Radie = 4 },
            new Parallellogram { Base = 6, Height = 4 },
            new Ellips { LargeAxis = 5, LilAxis = 3 }
            };

            foreach (var objekt in geometriskaObjekt)
            {
                Console.WriteLine($"{objekt.ShapeName()}: {objekt.Area()}");
            }
        }
    }
}