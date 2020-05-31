using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Flight
    {
        public int FlightNo { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public DateTime Date { get; set; }

        public short TotalSeats { get; set; }

        public float BasePrice { get; set; }

        public short SeatsBooked { get; set; }


    }
}
