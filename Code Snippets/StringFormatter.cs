using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippets
{
    class StringFormatter
    {
        private static void Main(string[] args)
        {
            decimal temp = 20.4m;
            string t = string.Format("The temperature is {0}°C.", temp);
            Console.WriteLine(t);

            string d = string.Format("It is now {0:t} at {0:d}", DateTime.Now);
            Console.WriteLine(d);

            int[] years =
            {
                2013,
                2014,
                2015
            };
            int[] population =
            {
                1025632,
                1105967,
                1148203
            };
            string s = string.Format("{0,-10} {1,-10}\n\n", "Year", "Population");
            for (int index = 0; index < years.Length; index++)
            {
                s += string.Format("{0,-10} {1,-10:N0}\n", years[index], population[index]);
            }

            Console.WriteLine($"\n{s}");


            decimal pricePerOunce = 17.36m;
            string ppo = string.Format("The current price is {0} per ounce.", pricePerOunce);
            string ppp = string.Format("The current price is {0:C2} per ounce.", pricePerOunce);
            Console.WriteLine(ppo);
            Console.WriteLine(ppp);


            Console.ReadLine();
        }
    }
}

