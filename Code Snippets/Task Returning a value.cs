using System;
using System.Threading;
using System.Threading.Tasks;

namespace Code_Snippets
{
    class Task_Returning_a_value
    {
        public static int CalculateResult()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
            return 99;
        }

        static void Main(string[] args)
        {
            //Task<int> task = task.Run(() =>
            //{
            //    return CalculateResult();
            //});

            //Console.WriteLine(task.Result);

            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();

        }
    }
}
