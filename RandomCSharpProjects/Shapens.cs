using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSharpProjects
{
    class Shapens
    {
        public string Type = "square";
        public int Sides = 4;
        public int Sidelength = 1;

        public double Area { get; }

        public double area = 1;
        public Shapens(string type, int sides, int sidelength, double area)
        {
            Type = type;
            Sides = sides;
            Sidelength = sidelength;
            Area = area;
        }
    }
}
