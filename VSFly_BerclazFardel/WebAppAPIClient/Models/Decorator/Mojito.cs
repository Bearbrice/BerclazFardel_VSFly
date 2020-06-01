using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAPIClient.Models.Decorator
{
    public class Mojito : FlightModel
    {
        private FlightModel f;

        public Mojito(FlightModel f)
        {
            this.f = f;
        }

        public override string GetDescription()
        {
            return f.GetDescription() + " with a mojito";
        }

    }
}
