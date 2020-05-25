using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class BookingManager
    {
        private static readonly HttpClient Httpclient;

        static BookingManager()
        {
            Httpclient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44319/api/booking")
            };

        }

    }
}
