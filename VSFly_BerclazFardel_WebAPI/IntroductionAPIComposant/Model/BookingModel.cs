using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class BookingModel
    {
        public int FlightNo { get; set; }
        public int PassengerID { get; set; }
        public double SalesPrice { get; set; }
    }
}
