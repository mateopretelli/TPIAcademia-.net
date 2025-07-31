using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public static class ApiClientProvider
    {
        private static readonly HttpClient client = new HttpClient();

        static ApiClientProvider()
        {
            client.BaseAddress = new Uri("http://localhost:5130/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static HttpClient GetClient()
        {
            return client;
        }
    }
}
