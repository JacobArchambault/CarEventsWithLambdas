using System;

namespace CarEventsWithLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** More fun with Lambdas\n");

            // Make a car as usual.
            Car c1 = new Car("Slugbug", 100, 10);

            // Hook into events with lambdas!
            c1.AboutToBlow += (sender, e) => Console.WriteLine(e.msg);
            c1.Exploded += (sender, e) => Console.WriteLine(e.msg);

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            Console.ReadLine();
        }
    }
}
