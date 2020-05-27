using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAPIClient.Models;

namespace WebAppAPIClient.ViewModel
{
    public class FlightBooking
    {
        public FlightModel Flight { get; set; }

        public double SalesPrice { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
