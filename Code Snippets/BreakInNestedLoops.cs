using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippets
{
    class BreakInNestedLoops
    {
        static void Main(string[] args)
        {

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            // Outer loop.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"num = {numbers[i]}");

                // Inner loop.
                for (int j = 0; j < letters.Length; j++)
                {
                    if (j == i)
                    {
                        // Return control to outer loop.
                        break;
                    }
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
