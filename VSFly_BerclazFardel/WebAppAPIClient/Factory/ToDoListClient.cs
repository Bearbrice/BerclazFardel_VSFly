using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAPIClient.Factory;
using WebAppAPIClient.Models;

namespace WebAppAPIClient
{
    public partial class ApiClient
    {
        // GET : FLIGHTS - ALL
        public async Task<List<FlightModel>> GetAllFlights()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Flight/"));
            return await GetAsync<List<FlightModel>>(requestUrl);
        }

        // GET : FLIGHT - SINGLE
        public async Task<FlightModel> GetFlight(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                ("Flight/"+id)));
            return await GetAsync<FlightModel>(requestUrl);
        }

        // GET : PASSENGER - SINGLE
        public async Task<Passenger> GetPassenger(string firstname, string lastname)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                ("Passenger/" + firstname + "/" + lastname)));
            return await GetAsync<Passenger>(requestUrl);
        }

        // GET : BOOKING - SINGLE
        public async Task<Booking> GetBooking(int flightNo, int passengerID)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                ("Booking/" + flightNo + "/" + passengerID)));
            return await GetAsync<Booking>(requestUrl);
        }

        //POST : BOOKING
        public async Task<Message<Booking>> PostBooking(Booking model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Booking/"));
            return await PostAsync<Booking>(requestUrl, model);
        }

        //PUT : FLIGHT
        public async Task<Message<FlightModel>> PutFlight(int id, FlightModel fm)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Flight/"+id));
            return await PutAsync<FlightModel>(requestUrl, fm);
        }


        /* ---------------------------- DEV --------------------------*/

        //POST : Passenger
        public async Task<Message<Passenger>> PostPassenger(Passenger model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Passenger/"));
            return await PostAsync<Passenger>(requestUrl, model);
        }

        //public async Task<Message<TodoItem>> SaveTodoItem(TodoItem model)
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        "TodoItems/"));
        //    return await PostAsync<TodoItem>(requestUrl, model);
        //}

        public async Task<List<TodoItem>> GetTodoItems()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "TodoItems/"));
            return await GetAsync<List<TodoItem>>(requestUrl);
        }







    }
}
