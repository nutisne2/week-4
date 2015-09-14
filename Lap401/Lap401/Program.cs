﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap401
{
    class Program
    {
            public static void Main(string[] args)
        {
            // Test Program for Lab401
            Circle c1 = new Circle(), c2 = new Circle(1.5, 5.0, 2), c3 = new Circle(c2);
            Console.WriteLine(c1 + "\n" + c2 + "\n" + c3);

            Cylinder cl1 = new Cylinder(), cl2 = new Cylinder(c3), cl3 = new Cylinder(1, 1, 3, 4);
            Cylinder cl4 = new Cylinder(cl3);
            Console.WriteLine(cl1 + "\n" + cl2 + "\n" + cl3 + "\n" + cl4);
        }
    }
   
}
