using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace BLL
{
    public class FlightManager
    {
        private static readonly HttpClient Httpclient;

        static FlightManager()
        {
            Httpclient = new HttpClient();
            Httpclient.BaseAddress = new Uri("http://localhost:64961/api/");
        }

        public static async Task<List<Flight>> GetAllFlightsAsync()
        {
            List<Flight> flights = null;
            //return DAL.HotelDB.GetAllHotel();
            //HTTP GET
            var responseTask = await Httpclient.GetAsync("flights");

            if (responseTask.IsSuccessStatusCode)
            {
                flights = await responseTask.Content.ReadAsAsync<List<Flight>>();

            }
            return flights;

        }

        public static async Task<string> GetFlightDepartureAsync(int idFlight)
        {
            List<Flight> flightList = await GetAllFlightsAsync();

            foreach (Flight f in flightList)
            {
                if (idFlight == f.idFlight)
                {
                    return f.departure;
                }
            }

            return null;
        }



    }
}
