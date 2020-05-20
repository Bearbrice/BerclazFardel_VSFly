using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore
{
    public class Passenger
    {

        [Key]
        public int PersonID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public virtual ICollection<Booking> BookingSet { get; set; }

    }
}
