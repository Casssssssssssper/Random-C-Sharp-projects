using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Code_Snippets
{
    class Task_Await
    {
        public static void DoWork(int i)
        {
            Console.WriteLine("Task {0} starting", i);
            Thread.Sleep(2000);
            Console.WriteLine("Task {0} finished", i);
        }

        static void Main(string[] args)
        {
            Task[] Tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                int taskNum = i;
                // making a locacal copy of the loop count.
                // correct task number is passed into lambda expression

                Task[i] = Task.Run(() => DoWork(taskNum));
                //Asynchronous task so this requires a Task.WaitAll method.
            }
            Task.WaitAll(Task);

            Console.WriteLine("Finished	processing.	Press a key	to end the application.");
            Console.ReadKey();

        }
    }
}
