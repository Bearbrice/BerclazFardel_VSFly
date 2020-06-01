using System;
using WebAppAPIClient;
using WebAppAPIClient.Models.Decorator;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //FlightModel f = new FlightModel();

            //Console.WriteLine(f.GetDescription());

            //f = new Film(f);

            //Console.WriteLine(f.GetDescription());

            //f = new Popcorn(f);

            //Console.WriteLine(f.GetDescription());


            Flight f = new Flight();
            Console.WriteLine(f.GetDescription());

            f = new Mojito(f);
            f = new Mojito(f);
            Console.WriteLine(f.GetDescription());




        }
    }
}
