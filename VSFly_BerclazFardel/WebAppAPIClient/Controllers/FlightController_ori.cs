using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO;
using BLL;

namespace WebAppAPIClient.Controllers
{
    public class FlightController_ori : Controller
    {
        // GET: Flight
        public ActionResult Index()
        {
            return View();
        }

        // GET: Flight/Details/5
        public async Task<ActionResult> GetFlight(int id)
        {
            var flights = await FlightManager.GetAllFlightsAsync();

            var flight = new Flight();

            foreach(Flight f in flights)
            {
                if (f.FlightNo == id)
                {
                    flight = f;
                }
            }

            return View(flight);
        }

        // GET: Flight
        public async Task<ActionResult> GetAllFlights()
        {
            var flights = await FlightManager.GetAllFlightsAsync();

            return View(flights);
        }

        // GET: Flight/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Flight/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Flight/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
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

        // GET: Flight/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Flight/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Flight/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Flight/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}