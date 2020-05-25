using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class PassengerManager
    {
        private static readonly HttpClient Httpclient;

        static PassengerManager()
        {
            Httpclient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44333/api/passenger")
            };

        }
    }
}
