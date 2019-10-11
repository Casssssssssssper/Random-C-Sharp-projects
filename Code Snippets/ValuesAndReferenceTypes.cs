using System;

namespace Code_Snippets
{
    internal class ValuesAndReferenceTypes
    {
        private struct StructStore { public int Data { get; set; } }

        private class ClassStore { public int Data { get; set; } }

        private static void Main(string[] args)
        {
            StructStore xs, ys; ys = new StructStore
            {
                Data = 99
            };

            xs = ys;
            xs.Data = 100;

            Console.WriteLine("xStruct:	{0}", xs.Data);
            Console.WriteLine("yStruct:	{0}", ys.Data);

            ClassStore xc, yc; yc = new ClassStore
            {
                Data = 99
            };

            xc = yc;
            xc.Data = 100;

            Console.WriteLine("xClass:	{0}", xc.Data);
            Console.WriteLine("yClass:	{0}", yc.Data);

            Console.ReadKey();

            /* Output:

            xStruct:	100 
            yStruct:	99

            and

            xStruct:	100 
            yStruct:	100

            */

        }
    }
}
