using EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI;

namespace IntroductionAPIComposant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly VSFlightContext _context;

        public BookingController(VSFlightContext context)
        {
            _context = context;
        }

        // GET: api/booking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>>> GetAllBookings()
        {
            return await _context.BookingSet.ToListAsync();
        }

        // GET: api/booking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetBooking(int id)
        {
            var Booking = await _context.BookingSet.FindAsync(id);

            if (Booking == null)
            {
                return NotFound();
            }

            return Booking;
        }

        // POST: api/booking
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            _context.BookingSet.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }
    }
}
