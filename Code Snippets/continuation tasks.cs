using System;
using System.Threading;
using System.Threading.Tasks;

namespace Code_Snippets
{
    internal class continuation_tasks
    {
        public static void HelloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
        }

        public static void WorldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("world");
        }

        private static void Main(string[] args)
        {
            Task task = Task.Run(() => HelloTask());
            task.ContinueWith((prevTask) => WorldTask());

            //task.ContinueWith((prevTask) => WorldTask(), TaskContinuationOptions.OnlyOnRanToCompletion);

            //task.ContinueWith((prevTask) => ExceptionTask(), TaskContinuationOptions


            Console.WriteLine("Finished processing. Press a key to end the application.");
            Console.ReadKey();
        }
    }
}
