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

        static void Main(string[] args)
        {
            Parallel.Invoke(() => Task1(), () => Task2());
            Console.WriteLine("Finished processing. press a key to end");
            Console.ReadKey();
        }
    }
}
