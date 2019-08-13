using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Snippets
{
    class ManagingParallelForLoop
    {
        static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500).ToArray();
            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoop {
                if (i == 200) loopState.Stop();
                WorkOnItem(items[i]);
            });

            Console.WriteLine("Completed:	" + result.IsCompleted); Console.WriteLine("Items:	" + result.LowestBreakIteration);
            Console.WriteLine("Finished	processing.	Press	a	key	to	end."); Console.ReadKey();
        }
    }
}
