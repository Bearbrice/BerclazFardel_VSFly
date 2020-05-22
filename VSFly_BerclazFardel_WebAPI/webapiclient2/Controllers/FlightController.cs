using EFCore;
using System.Linq;
using System.Web.Http;

namespace webapiclient2_EXEMPLE.Controllers
{
    [RoutePrefix("api/flights")]
    public class FlightController : ApiController
    {
        static VSFlightContext context = new VSFlightContext();

        [Route("")]
        public IHttpActionResult GetAllFlights()
        {
            var flights = context.FlightSet.ToList();

            return Ok(flights);
        }

    }
}
