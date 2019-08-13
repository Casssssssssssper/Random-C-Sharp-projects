using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Code_Snippets
{
    internal class ParallelForEach
    {
        private static void WorkOnItem(object item)
        {
            Console.WriteLine("Started	working	on:	" + item);
            Thread.Sleep(100);
            Console.WriteLine("Finished	working	on:	" + item);
        }

        private static void Main(string[] args)
        {
            //System.Collections.Generic.IEnumerable<int> items = Enumerable.Range(0, 500);

            //Parallel.ForEach(items, item => {
            //    WorkOnItem(item);
            //});

            var items = Enumerable.Range(0, 500).ToArray();

            Parallel.For
            (
                0, items.Length, i =>
                    {
                        WorkOnItem(items[i]);
                    }
            );

            Console.WriteLine("Finished	processing.	Press	a	key	to	end.");
            Console.ReadKey();
        }

    }
}
