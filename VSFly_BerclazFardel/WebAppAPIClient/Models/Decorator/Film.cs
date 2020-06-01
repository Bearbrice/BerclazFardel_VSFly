using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAPIClient.Models.Decorator
{
    public class Film : FlightModel
    {
        private FlightModel f;

        public Film(FlightModel f)
        {
            this.f = f;
        }

        public override string GetDescription()
        {
            return f.GetDescription() + " with a film";
        }

    }
}
