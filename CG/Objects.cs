﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CG
{
    abstract class Object
    {
        public double[] center;
        public double[] color;
    }

    class Sphere : Object
    {
        public double radius;

        public Sphere(double[] center, double radius, double[] color)
        {
            this.center = center;
            this.color = color;
            this.radius = radius;

            Console.WriteLine("Sphere was a create");
        }
    }
}
