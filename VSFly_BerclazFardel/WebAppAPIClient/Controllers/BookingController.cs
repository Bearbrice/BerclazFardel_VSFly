using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebAppAPIClient.Factory;
using WebAppAPIClient.Models;
using WebAppAPIClient.Utility;
using WebAppAPIClient.ViewModel;

namespace WebAppAPIClient.Controllers
{
    public class BookingController : Controller
    {
        private readonly ILogger<BookingController> _logger;
        private readonly IOptions<MySettingsModel> appSettings;

        public BookingController(ILogger<BookingController> logger, IOptions<MySettingsModel> app)
        {
            appSettings = app;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
            _logger = logger;
        }

        // GET: Customer/Create
        public ActionResult Create(FlightModel flightModel)
        {

            FlightBooking fb = new FlightBooking();
            fb.Flight = flightModel;

            
            return View(fb);
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FlightBooking flightBooking)
        {
            //c.fk_idCity = CityManager.GetIdCity(c.fk_idCity);

            //if (c.fk_idCity == 0)
            //{
            //    return RedirectToAction("Create", "Customer", new { errorMessage = "City code invalid or not available" });
            //}
            //else
            //{
            //    CustomerManager.AddCustomer(c);
            //    HttpContext.Session.SetString("idCustomer", c.idCustomer.ToString());
            //    return RedirectToAction("Create", "Login", new { c.idCustomer });
            //}

            return View();
        }






    }
}
