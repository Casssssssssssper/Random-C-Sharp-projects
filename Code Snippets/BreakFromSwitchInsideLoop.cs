using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippets
{
    class BreakFromSwitchInsideLoop
    {
        static void Main(string[] args)
        {
            // loop 1 to 3
            for (int i = 1; i <= 3; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Current value is 1");
                        break;
                    case 2:
                        Console.WriteLine("Current value is 2");
                        break;
                    case 3:
                        Console.WriteLine("Current value is 3");
                        break;
                    default:
                        Console.WriteLine("This shouldn't happen.");
                        break;
                }
            }

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
