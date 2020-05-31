using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAPIClient.Models;

namespace WebAppAPIClient
{
    public partial class ApiClient
    {
        public async Task<List<TodoItem>> GetTodoItems()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "TodoItems/"));
            return await GetAsync<List<TodoItem>>(requestUrl);
        }

        //public async Task<Message<TodoItem>> SaveTodoItem(TodoItem model)
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        "TodoItems/"));
        //    return await PostAsync<TodoItem>(requestUrl, model);
        //}


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

        //POST : BOOKING
        public async Task<Message<Booking>> PostBooking(Booking model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Booking/"));
            return await PostAsync<Booking>(requestUrl, model);
        }

        //POST : Passenger
        public async Task<Message<Passenger>> PostPassenger(Passenger model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Passenger/"));
            return await PostAsync<Passenger>(requestUrl, model);
        }



    }
}
