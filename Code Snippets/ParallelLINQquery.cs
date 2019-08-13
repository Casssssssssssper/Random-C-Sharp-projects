using System;
using System.Linq;

namespace Code_Snippets
{
    internal class ParallelLINQquery
    {
        public string Name { get; set; }
        public string City { get; set; }
    }

    private static void Main(string[] args)
    {

        //var result = from person in people.AsParallel().
        //             WithDegreeOfParallelism(4).
        //             WithExecutionMode(ParallelExecutionMode.
        //             ForceParallelism
        //             where	person.City == "Seattle"
        //             select	person;

        //var result = from person in people.AsParallel().AsOrdered()
        //             where person.City == "Seattle"
        //             select person;

        //var result = (from person in people.AsParallel()
        //              where person.City == "Seattle"
        //              orderby (person.Name)
        //              select new
        //              {
        //                  Name = person.Name
        //              }).AsSequential().Take(4);

        //var result = from person 
        //             in people.AsParallel()
        //             where person.City == "Seattle"
        //             select person;
        //result.ForAll(person => Console.WriteLine(person.Name));

        // for exceptions
        //public static bool CheckCity(string name)
        //{
        //    if (name == "")
        //        throw new ArgumentException(name);
        //    return name == "Seattle";
        //}

        //try
        //{
        //    var result = from person 
        //                 in people.AsParallel()
        //                 where CheckCity(person.City)
        //                 select person; result.ForAll(person => Console.WriteLine(person.Name));
        //}
        //catch (AggregateException e)
        //{
        //    Console.WriteLine(e.InnerExceptions.Count + "exceptions.");
        //}


        ParallelLINQquery[] people = new ParallelLINQquery[]
        {
            new ParallelLINQquery
            { Name = "Alan", City = "Hull" },
            new ParallelLINQquery
            { Name = "Beryl", City = "Seattle" },
            new ParallelLINQquery
            { Name = "Charles", City = "London" },
            new ParallelLINQquery
            { Name = "David", City = "Seattle" },
            new ParallelLINQquery
            { Name = "Eddy", City = "Paris" },
            new ParallelLINQquery
            { Name = "Fred", City = "Berlin" },
            new ParallelLINQquery
            { Name = "Gordon", City = "Hull" },
            new ParallelLINQquery
            { Name = "Henry", City = "Seattle" },
            new ParallelLINQquery
            { Name = "Isaac", City = "Seattle" },
            new ParallelLINQquery
            { Name = "James", City = "London" }
        };

        ParallelQuery<ParallelLINQquery> result = from person in people.AsParallel() where person.City == "Seattle" select person;
        foreach (ParallelLINQquery person in result)
        {
            Console.WriteLine(person.Name);
        }

        Console.WriteLine("Finished	processing.	Press	a	key	to	end."); Console.ReadKey();
    }
}
