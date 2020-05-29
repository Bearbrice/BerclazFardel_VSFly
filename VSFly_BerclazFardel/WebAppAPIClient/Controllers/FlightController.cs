﻿using System;
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
        public async Task<ActionResult> GetAllFlights()
        {
            var flights = await ApiClientFactory.Instance.GetAllFlights();
            
            return View(flights);
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
