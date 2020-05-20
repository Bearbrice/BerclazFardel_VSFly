using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public class Booking
    {
        // Flight - Passenger
        public int FlightNo { get; set; }
        public int PassengerID { get; set; }

        public double SalesPrice { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}
