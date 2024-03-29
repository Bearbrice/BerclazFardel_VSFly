﻿using EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI;
using WebAPI.Model;

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

        /// <summary>
        /// Method to calculate the selling price of a flight based on its departure date and its fill rate
        /// </summary>
        public float CalculSalesPrice(Flight flight)
        {
            float basePrice = flight.BasePrice;
            DateTime flightDate = flight.Date;

            double pourcentage = (double)(flight.SeatsBooked / flight.TotalSeats) * 100;

            DateTime date = DateTime.Now;

            TimeSpan diff = flightDate - date;

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

        //a. Return all available flights(not full)
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

        // Will be useful in the web client to get all attributes of a flight easily
        // GET: api/flight/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var flight = await _context.FlightSet.FindAsync(id);

            if (flight == null)
            {
                return NotFound();
            }

            flight.BasePrice = CalculSalesPrice(flight);

            return flight;
        }

        //b. Return the sale price of a flight
        // GET: api/flight/1/price
        [HttpGet("{id}/price")]
        public async Task<ActionResult<double>> GetFlightPrice(int id)
        {
            var flight = await _context.FlightSet.FindAsync(id);

            if (flight == null)
            {
                return NotFound();
            }

            flight.BasePrice = CalculSalesPrice(flight);

            return flight.BasePrice;
        }

        //d. Return the total sale price of all tickets sold for a flight
        // GET: api/flight/1/totalsales
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

        //e. Return the average sale price of all tickets sold for a destination (multiple flights possible)
        // GET: api/flight/avg/geneve
        [HttpGet("avg/{dest}")]
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

            return salesPriceTotal / count;
        }

        //f. Return the list of all tickets sold for a destination with the first and last name of the travelers and the flight number as well as the sale price of each ticket.
        // GET: api/Flight/tickets/geneve
        [HttpGet("tickets/{dest}")]
        public async Task<ActionResult<IEnumerable<BookingDestinationModel>>> GetDestTickets(string dest)
        {
            List<Flight> lf = await _context.FlightSet.Where(x => x.Destination.Equals(dest)).ToListAsync();

            List<BookingDestinationModel> bdmList = new List<BookingDestinationModel>();
            BookingDestinationModel bdm;

            foreach (Flight f in lf)
            {
                foreach (Booking b in f.BookingSet)
                {
                    bdm = new BookingDestinationModel
                    {
                        FlightNo = f.FlightNo,
                        Firstname = b.Passenger.Firstname,
                        Lastname = b.Passenger.Lastname,
                        SalesPrice = b.SalesPrice
                    };
                     bdmList.Add(bdm);
                }

            }
            return bdmList;
        }

        //c. Buying a ticket on a flight
        // PUT: api/flight/1
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlight(int id)
        {
            var flight = await _context.FlightSet.FindAsync(id);

            if (flight == null)
            {
                return NotFound();
            }

            flight.SeatsBooked += 1;

            _context.Entry(flight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightExists(id))
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

        // POST: api/flight
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Flight>> PostFlight(Flight flight)
        {
            _context.FlightSet.Add(flight);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFlight", new { id = flight.FlightNo }, flight);
        }

        // DELETE: api/flight/5
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

        // Method to check if a flight exists
        private bool FlightExists(int id)
        {
            return _context.FlightSet.Any(e => e.FlightNo == id);
        }
    }
}
