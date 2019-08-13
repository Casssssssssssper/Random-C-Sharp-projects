using System;
using System.Threading;
using System.Threading.Tasks;

namespace Code_Snippets
{
    internal class Creating_A_Task
    {
        public static void DoWork()
        {
            Console.WriteLine("Work	starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work	finished");
        }

        private static void Main(string[] args)
        {
            Task newTask = new Task(() => DoWork());
            newTask.Start();
            newTask.Wait();
        }
    }
}
