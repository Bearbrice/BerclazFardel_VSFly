using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebAppAPIClient.Factory;
using WebAppAPIClient.Models;
using WebAppAPIClient.Utility;
using WebAppAPIClient.ViewModel;

namespace WebAppAPIClient.Controllers
{
    public class FlightController : Controller
    {
        private readonly ILogger<FlightController> _logger;
        private readonly IOptions<MySettingsModel> appSettings;

        public FlightController(ILogger<FlightController> logger, IOptions<MySettingsModel> app)
        {
            appSettings = app;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
            _logger = logger;
        }

        // GET: Flights
        public async Task<ActionResult> GetAllFlights(string sortOrder, string sDeparture, string sDestination, string sDate)
        {
            var flights = await ApiClientFactory.Instance.GetAllFlights();

            IEnumerable<FlightModel> fm = flights;

            /*FIND*/
            if (!String.IsNullOrEmpty(sDeparture))
            {
                fm = fm.Where(f => f.Departure.Contains(sDeparture));
            }
            if (!String.IsNullOrEmpty(sDestination))
            {
                fm = fm.Where(f => f.Destination.Contains(sDestination));
            }
            if (!String.IsNullOrEmpty(sDate))
            {
                fm = fm.Where(f => f.Date.ToString().Substring(0, 10) == sDate);
            }

            /*SORT*/
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "price_desc" : "Price";

            switch (sortOrder)
            {
                case "price_desc":
                    fm = fm.OrderByDescending(f => f.BasePrice);
                    break;
                case "Price":
                    fm = fm.OrderBy(f => f.BasePrice);
                    break;
                case "Date":
                    fm = fm.OrderBy(f => f.Date);
                    break;
                case "date_desc":
                    fm = fm.OrderByDescending(f => f.Date);
                    break;
            }

            return View(fm);

            //return View(flights);
        }

        // GET: Flights
        public async Task<ActionResult> GetFlight(int id)
        {
            var flight = await ApiClientFactory.Instance.GetFlight(id);

            //FlightBooking fb = new FlightBooking();
            //fb.Flight = flight;
            
            return View(flight);
        }

        // GET: Flight
        public async Task<ActionResult> Details(int id)
        {
            var flight = await ApiClientFactory.Instance.GetFlight(id);

            FlightBooking fb = new FlightBooking();
            fb.Flight = flight;

            return View(fb);
        }

        //// POST: Default/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Details2(int id, float basePrice, string firstname, string lastname)
        //{

        //    var flight = await ApiClientFactory.Instance.GetFlight(id);




        //    return View();
        //}


        // POST: Default/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Details(int flightNo, string firstname, string lastname, float basePrice)
        {
            /* --- PASSENGER MNGMT --- */
            /*Check if passenger exist*/
            var passenger = new Passenger();

            try
            {
                passenger = await ApiClientFactory.Instance.GetPassenger(firstname, lastname);
            }
            catch (Exception e)
            {
                Console.WriteLine("No passenger found.");
                return RedirectToAction("Details", new { id = flightNo });
            }


            /* --- BOOKING MNGMT --- */
            // Create booking to database
            Booking b = new Booking();
            b.FlightNo = flightNo;
            b.PassengerID = passenger.PersonID;
            b.SalesPrice = basePrice;

            //HTTP POST 
            var postBooking = await ApiClientFactory.Instance.PostBooking(b);


            /* --- FLIGHT MNGMT --- */
            /*Update flight*/
            //HTTP PUT
            var flight = await ApiClientFactory.Instance.GetFlight(flightNo);

            var putFlight = await ApiClientFactory.Instance.PutFlight(flightNo, flight);



            /* STEP 1 : Retrive client ID */

            /*1.1 - PENDING */
            /* WON'T BE DONE IN PRIORITY - WE SAY ONLY EXISTING PASSENGER CAN BOOK*/
            //Create client
            //int passengerId   = CreateClient(fb.Firstname, fb.Lastname);

            /*1.2*/


            //Check if passenger existing
            //var passenger = await ApiClientFactory.Instance.GetPassenger(firstname, lastname);






            // ABORTED - Create passenger to database
            /*Passenger p = new Passenger();
            p.Firstname = firstname;
            p.Lastname = lastname;

            //HTTP POST 
            var postPassenger = await ApiClientFactory.Instance.PostPassenger(p);

            if (postPassenger.isSuccess)
            {

            }
            else
            {

            }*/



            ///* FLIGHT MNGMT */



            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //public async Task<IActionResult> IndexAsync()
        //{
        //    var data = await ApiClientFactory.Instance.GetTodoItems();
        //    return View(data);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
