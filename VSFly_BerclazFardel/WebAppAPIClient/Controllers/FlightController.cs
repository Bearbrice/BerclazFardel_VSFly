using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
                fm = fm.Where(f => f.Date.ToString().Substring(0,10)==sDate);
            }

            ///*SORT*/
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

        // POST: Default/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Details(int id, string firstname, string lastname)
        {
            /* STEP 1 : Retrive client ID */

            /*1.1 - PENDING */
            /* WON'T BE DONE IN PRIORITY - WE SAY ONLY EXISTING PASSENGER CAN BOOK*/
            //Create client
            //int passengerId   = CreateClient(fb.Firstname, fb.Lastname);

            /*1.2*/




            //Create booking
            BookingModel bm = new BookingModel();
            
            //bm.FlightNo = fb.Flight.FlightNo;
            //bm.SalesPrice = fb.Flight.BasePrice;

            //Notify that a place is no available no more



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
