using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    interface IBookingManager
    {
        void AddBooking();

        Booking ShowBookings(Passenger passenger);

    }
}
