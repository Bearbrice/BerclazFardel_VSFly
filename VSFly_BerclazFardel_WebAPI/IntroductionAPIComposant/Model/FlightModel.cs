﻿using System;

namespace WebAPI.Model
{
    public class FlightModel
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
