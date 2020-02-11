using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCSharpProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape myObject = new Shape();

            Shapens square = new Shapens("square", 4, 1, 1);
            Shapens bigsquare = new Shapens("square", 4, 2, 4);
            Shapens triangle = new Shapens("triangle", 3, 3, 3.9);
            Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", square.Type, square.Sides, square.Sidelength, square.Area);
            Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", bigsquare.Type, bigsquare.Sides, bigsquare.Sidelength, bigsquare.Area);
            Console.WriteLine("A {0} with {1} sides of length {2} has an area of {3}", triangle.Type, triangle.Sides, triangle.Sidelength, triangle.Area);

            Console.WriteLine("");

            Console.ReadKey(true);
         
                
           
        }
    }
}
