using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAPIClient.Models.Decorator
{
    public class Popcorn : Flight
    {
        protected static string _description = "with popcorn ";

        private Flight Flight = null;

        public Popcorn(Flight flight)
        {
            this.Flight = flight;
        }

        public override string GetDescription()
        {
            return this.Flight.GetDescription() + _description;
        }
    }
}
