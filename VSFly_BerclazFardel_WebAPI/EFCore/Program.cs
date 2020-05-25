using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDatabase();

            PrintFlights();

        }

        private static void CreateDatabase()
        {
            using (var ctx = new VSFlightContext_OFF())
            {
                var e = ctx.Database.EnsureCreated();

                if (e)
                    Console.WriteLine("Database has been created !");
            }
        }

        private static void PrintFlights()
        {
            Console.WriteLine("------------------------- PRINT FLIGHTS -------------------------------");

            using (var ctx = new VSFlightContext_OFF())
            {
                // Needs using System.Linq;
                var q = from f in ctx.FlightSet
                        select f;

                foreach (Flight f in q)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", f.FlightNo, f.Departure, f.Destination, f.Seats, f.BasePrice);
                }
            }
        }



    }
}
