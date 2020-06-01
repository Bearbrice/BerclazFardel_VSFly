using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppAPIClient.Models.Decorator
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

        private string Description = "You have succesfully booked this flight";

        public FlightModel()
        {
        }

        public virtual string GetDescription()
        {
            return Description;
        }


    }
}
