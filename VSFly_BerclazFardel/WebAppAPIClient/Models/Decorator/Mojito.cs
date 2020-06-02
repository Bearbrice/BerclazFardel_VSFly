using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAPIClient.Models.Decorator
{
    public class Mojito : Flight
    {
        protected static string _description = "with a mojito ";

        private Flight Flight = null;

        public Mojito(Flight flight)
        {
            this.Flight = flight;
        }

        public override string GetDescription()
        {
            return this.Flight.GetDescription() + _description;
        }
    }
}
