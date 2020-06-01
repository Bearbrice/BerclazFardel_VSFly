using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAPIClient.Models.Decorator
{
    public class Popcorn : FlightModel
    {
        private FlightModel f;

        public Popcorn(FlightModel f)
        {
            this.f = f;
        }

        public override string GetDescription()
        {
            return f.GetDescription() + " with some delicious popcorn";
        }
    }
}
