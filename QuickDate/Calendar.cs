using System;

namespace QuickDate
{

    internal class Calendar
    {

        static void Main(string[] args)
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"Today's date is {now}");
            Console.ReadLine();
        }

        internal static DateTime GetCurrentDate(DateTime date)
        {
            return DateTime.Now.Date;

            // https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-projects-solutions?view=vs-2019

        }
    }
   

}