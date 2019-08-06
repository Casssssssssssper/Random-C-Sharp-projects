using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Code_Snippets
{
    internal class Parallel_Invoke
    {
        private static void Task1()
        {
            Console.WriteLine("Task 1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending");
        }

        private static void Task2()
        {
            Console.WriteLine("Task 2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 1 ending");
        }

        //static void Main(string[] args)
        //{
        //    Parallel.Invoke(() => Task1(), () => Task2());
        //    Console.WriteLine("Finished processing. press a key to end");
        //    Console.ReadKey();
        //}

        // -----> Other way of doing this.

        private static void WorkOnItem(object item)
        {
            Console.WriteLine("Finished processing. press a key to end");
            Thread.Sleep(100);
            Console.WriteLine("Finished working on: " + item);
        }

        private static void Main(string[] args)
        {
            var items = Enumerable.Range(0, 500)
            Parallel.ForEach(items, item => { WorkOnItem(item); });

            //Parallel.Invoke(() => private Task1(), () => private Task2());
            //Console.WriteLine("Finished processing. press a key to end");
            //Console.ReadKey();

            var items = Enumerable.Range(0, 500).ToArray();
            ParallelLoopResult result = Parallel.For(0, items.Count(), (int i, ParallelLoop                {
                if (i == 200) loopState.Stop();
                WorkOnItem(items[i]);
            });
            Console.WriteLine("Completed:	" + result.IsCompleted); Console.WriteLine("Items:	" + result.LowestBreakIteration);
            Console.WriteLine("Finished	processing.	Press	a	key	to	end."); Console.ReadKey();

        }







}
}
