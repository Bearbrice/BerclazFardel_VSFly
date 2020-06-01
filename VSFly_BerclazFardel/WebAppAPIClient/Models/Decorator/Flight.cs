using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAPIClient.Models.Decorator
{
    public class Flight
    {
        protected string Description = "You have successfully booked a flight ";

        public virtual string GetDescription()
        {
            return Description;
        }

    }

}
