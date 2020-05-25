﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class FlightModel
    {

        public int FlightNo { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public DateTime Date { get; set; }

        public short Seats { get; set; }

        public double BasePrice { get; set; }

    }
}
