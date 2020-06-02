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

        // GET: api/GetAllBookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking>>> GetAllBookings()
        {
            return await _context.BookingSet.ToListAsync();
        }

        // GET: api/GetBooking/5
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

        // PUT: api/ToDoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(long id, Booking Booking)
        {
            _context.Entry(Booking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }

            return NoContent();
        }

        // POST: api/ToDoItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking booking)
        {
            _context.BookingSet.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        // DELETE: api/ToDoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Booking>> DeleteBooking(long id)
        {
            var Booking = await _context.BookingSet.FindAsync(id);
            if (Booking == null)
            {
                return NotFound();
            }

            _context.BookingSet.Remove(Booking);
            await _context.SaveChangesAsync();

            return Booking;
        }
    }
}
