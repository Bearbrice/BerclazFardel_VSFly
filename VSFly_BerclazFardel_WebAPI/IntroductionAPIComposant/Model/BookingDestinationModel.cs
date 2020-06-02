using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class BookingDestinationModel
    {
        public int FlightNo { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double SalesPrice { get; set; }
    }
}
