﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Code_Snippets
{
    internal class Attached_child_task
    {
        public static void DoChild(object state)
        {
            Console.WriteLine("Child {0} starting", state);
            Thread.Sleep(2000);
            Console.WriteLine("Child {0} finished", state);
        }

        private static void Main(string[] args)
        {
            Task parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Parent	starts");

                for (int i = 0; i < 10; i++)
                {
                    int taskNo = i;
                    Task.Factory.StartNew((x) => DoChild(x),    //	lambda	expression																															
                    taskNo,	//	state	object																															
                    TaskCreationOptions.AttachedToParent);
                }
            });

            parent.Wait();  //	will	wait	for	all	the	attached	children	to	complete
            Console.WriteLine("Parent	finished.	Press	a	key	to	end.");
            Console.ReadKey();
        }
    }
}
