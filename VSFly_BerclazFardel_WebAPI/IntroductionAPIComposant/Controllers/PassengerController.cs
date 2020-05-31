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
    public class PassengerController : ControllerBase
    {
        private readonly VSFlightContext _context;

        public PassengerController(VSFlightContext context)
        {
            _context = context;
        }



        //// GET: api/Passenger
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Passenger>>> GetAllPassengers()
        //{
        //    List<Passenger> lf = await _context.PassengerSet.Where(x => x.SeatsBooked != x.TotalSeats).ToListAsync();

        //    // Method price
        //    foreach (Passenger f in lf)
        //    {
        //        // Calculate for each Passenger
        //        f.BasePrice = CalculSalesPrice(f);
        //    }

        //    return lf;
        //}

        // GET: api/Passenger/Brice/Berclaz
        [HttpGet("{firstname}/{lastname}")]
        public async Task<ActionResult<Passenger>> GetPassenger(string firstname, string lastname)
        {
            var passenger = await _context.PassengerSet.Where(p => p.Firstname == firstname && p.Lastname == lastname).FirstAsync();

            if (passenger == null)
            {
                return NotFound();
            }

            return passenger;
        }

        

        //// POST: api/ToDoItems
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Passenger>> PostPassenger(Passenger Passenger)
        //{
        //    _context.PassengerSet.Add(Passenger);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPassenger", new { id = Passenger.PassengerNo }, Passenger);
        //}


        private bool PassengerExists(int id)
        {
            return _context.PassengerSet.Any(e => e.PersonID == id);
        }
    }
}
