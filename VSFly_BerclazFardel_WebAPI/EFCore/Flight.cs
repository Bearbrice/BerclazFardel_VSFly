using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
    public class Flight
    {
        // Constructor
        public Flight() { }

        [Key]
        public int FlightNo { get; set; }

        [StringLength(50), MinLength(3)]
        public string Departure { get; set; }

        [StringLength(50), MinLength(3)]
        public string Destination { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public short? TotalSeats { get; set; }

        [Required]
        public float BasePrice { get; set; }

        public short SeatsBooked { get; set; }

        public virtual ICollection<Booking> BookingSet { get; set; }
    }
}
