using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Code_Snippets
{
    public class Circle
    {
        public Circle(double radius) { Radius = radius }

        public double Radius { get; set; }

        public double Diameter { get { return 2 * Radius; } }
        // Although this one is nice for how it looks but everytime the class is  --
        // referenced it has to perform the math function
        //public double Circumference { get; { return 2 * Radius * Math.PI; } }
        //public double Area { get { return Math.PI * Math.Pow(Radius, 2); } }

        // This is better, also with adding using static Syste.Math;
        public double Circumference => 2 * Radius * PI;
        public double Area => PI * Pow(Radius, 2);


    }
}
