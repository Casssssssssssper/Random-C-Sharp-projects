using System;
using System.Threading;

namespace Code_Snippets
{
    internal class ThreadsAndStuff
    {
        ////PARAMETERIZEDTHREADSTART
        //static void WorkOnData(object data)
        //{
        //    Console.WriteLine("Working	on:	{0}", data);
        //    Thread.Sleep(1000);
        //}
        //static void Main(string[] args)
        //{
        //    ParameterizedThreadStart ps = new ParameterizedThreadStart(WorkOnData);
        //    Thread thread = new Thread(ps);
        //    thread.Start(99);
        //}

        //// THREADS AND LAMBDA EXPRESSIONS
        //static void Main(string[] args)
        //{
        //    Thread thread = new Thread((data) =>
        //    {
        //        WorkOnData(data);
        //    });

        //    thread.Start(99);
        //}


        //// ABORTING A THREAD
        //static void Main(string[] args)
        //{
        //    Thread tickThread = new Thread(() =>
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine("Tick");
        //            Thread.Sleep(1000);
        //        }
        //    });

        //    tickThread.Start();
        //    Console.WriteLine("Press	a	key	to	stop	the	clock"); Console.ReadKey(); tickThread.Abort(); Console.WriteLine("Press	a	key	to	exit"); Console.ReadKey();
        //}

        //// A SHARED FLAG VARIABLE
        //static bool tickRunning; //	flag	variable	
        //static void Main(string[] args)
        //{
        //    tickRunning = true;
        //    Thread tickThread = new Thread(() => {
        //        while (tickRunning)
        //        {
        //            Console.WriteLine("Tick"); Thread.Sleep(1000);
        //        }
        //    });
        //    tickThread.Start();
        //    Console.WriteLine("Press	a	key	to	stop	the	clock"); Console.ReadKey(); tickRunning = false; Console.WriteLine("Press	a	key	to	exit"); Console.ReadKey();
        //}

        ////THREADJOIN
        //Thread threadToWaitFor = new Thread(() => { Console.WriteLine("Thread	starting"); Thread.Sleep(2000); Console.WriteLine("Thread	done"); });
        //threadToWaitFor.Start(); Console.WriteLine("Joining	thread"); threadToWaitFor.Join(); Console.WriteLine("Press	a	key	to	exit"); Console.ReadKey(); 


        //// THREAD LOCAL
        //public static ThreadLocal<Random> RandomGenerator = new ThreadLocal<Random>(() => 
        //{
        //    return new Random(2);
        //});

        // THREAD LOCAL V2
        //public static ThreadLocal<Random> RandomGenerator = new ThreadLocal<Random>(() => { return new Random(2); });
        //static void Main(string[] args)
        //{
        //    Thread t1 = new Thread(() => { for (int i = 0; i < 5; i++) { Console.WriteLine("t1:	{0}", RandomGenerator.Value.Next                                                                          Thread.Sleep(500); } });
        //    Thread t2 = new Thread(() => {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine("t2: {0}", RandomGenerator.Value.Next)
        //            Thread.Sleep(500);
        //        }
        //    }); t1.Start(); t2.Start(); Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    Thread t1 = new Thread(() =>
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine("t1:	{0}", RandomGenerator.Value.Next 
        //                Thread.Sleep(500);
        //        }
        //    });

        //    Thread t2 = new Thread(() => {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine("t2:	{0}",
        //                RandomGenerator.Value.Next
        //                Thread.Sleep(500);
        //        }
        //    }); t1.Start(); t2.Start(); Console.ReadKey();
        //}
    }
}
