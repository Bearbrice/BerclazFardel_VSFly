using EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAPI;

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

        private bool PassengerExists(int id)
        {
            return _context.PassengerSet.Any(e => e.PersonID == id);
        }
    }
}
