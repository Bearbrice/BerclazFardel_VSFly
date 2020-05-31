using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IntroductionAPIComposant.Model;
using WebAPI;
using WebAPI.Model;
using EFCore;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Extensions.Logging;

namespace IntroductionAPIComposant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly VSFlightContext _context;

        public FlightController(VSFlightContext context)
        {
            _context = context;
        }

        public double CalculSalesPrice(Flight flight)
        {
            double basePrice = flight.BasePrice;
            DateTime flightDate = flight.Date;

            double pourcentage = (double)(flight.SeatsBooked / flight.TotalSeats)*100;
            
            DateTime date = DateTime.Now;

            TimeSpan diff = flightDate - date ;

            double diffMonths = diff.TotalDays / 30;

            //1. If the airplane is more than 80 % full regardless of the date:
            //sale price = 150 % of the base price
            if (pourcentage > 80) 
            {
                return basePrice * 150 / 100;
            }

            //2. If the plane is filled less than 20 % less than 2 months before departure:
            //sale price = 80 % of the base price
            if (pourcentage < 20 && diffMonths < 2 && diffMonths > 1)
            {
                return basePrice * 80 / 100;
            }

            //3. If the plane is filled less than 50 % less than 1 month before departure:
            //sale price = 70 % of the base price
            if (pourcentage < 50 && diffMonths < 1)
            {
                return basePrice * 70 / 100;
            }


            return basePrice;
        }

        // GET: api/flight
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetAllFlights()
        {
            List<Flight> lf = await _context.FlightSet.Where(x => x.SeatsBooked != x.TotalSeats).ToListAsync();

            // Method price
            foreach (Flight f in lf)
            {
                // Calculate for each flight
                f.BasePrice = CalculSalesPrice(f);

            }

            return lf;
        }

        // GET: api/flight/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var flight = await _context.FlightSet.FindAsync(id);

            if (flight == null)
            {
                return NotFound();
            }

            flight.BasePrice = 10000;

            return flight;
        }

        // GET: api/GetFlightTotalSales/5
        [HttpGet("{id}/totalsales")]
        public async Task<ActionResult<double>> GetFlightTotalSales(int id)
        {
            var flight = await _context.FlightSet.FindAsync(id);

            if (flight == null)
            {
                return NotFound();
            }

            double salesPriceTotal = 0;
            foreach (Booking b in flight.BookingSet)
            {
                salesPriceTotal += b.SalesPrice;
            }

            return salesPriceTotal;
        }

        // GET: api/GetDestinationAvSales/GNV
        [HttpGet("dest/{dest}")]
        public async Task<ActionResult<double>> GetFlightTotalSales(string dest)
        {

            List<Flight> lf = await _context.FlightSet.Where(x => x.Destination.Equals(dest)).ToListAsync();
            double salesPriceTotal = 0;
            int count = 0;

            foreach (Flight f in lf)
            {
                foreach (Booking b in f.BookingSet) 
                {
                    salesPriceTotal += b.SalesPrice;
                    count++;
                }

            }

            return salesPriceTotal/count;
        }

        // PUT: api/ToDoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlight(long id, Flight flight)
        {
            if (id != flight.FlightNo)
            {
                return BadRequest();
            }

            _context.Entry(flight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ToDoItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Flight>> PostFlight(Flight flight)
        {
            _context.FlightSet.Add(flight);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlight", new { id = flight.FlightNo }, flight);
        }

        // DELETE: api/ToDoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Flight>> DeleteFlight(long id)
        {
            var flight = await _context.FlightSet.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }

            _context.FlightSet.Remove(flight);
            await _context.SaveChangesAsync();

            return flight;
        }

        private bool ToDoItemExists(long id)
        {
            return _context.FlightSet.Any(e => e.FlightNo == id);
        }
    }
}
