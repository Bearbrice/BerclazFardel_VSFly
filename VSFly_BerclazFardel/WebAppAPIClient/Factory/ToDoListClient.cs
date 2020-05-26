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

        public async Task<List<FlightModel>> GetAllFlights()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "Flight/"));
            return await GetAsync<List<FlightModel>>(requestUrl);
        }
    }
}
