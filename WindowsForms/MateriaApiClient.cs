using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class MateriaApiClient
    {
        private static HttpClient client = new HttpClient();
        static MateriaApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5130/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public static async Task<Materia> GetAsync(int id)
        {
            Materia materia = null;
            HttpResponseMessage response = await client.GetAsync("materias/" + id);
            if (response.IsSuccessStatusCode)
            {
                materia = await response.Content.ReadAsAsync<Materia>();
            }
            return materia;
        }

        public static async Task<IEnumerable<Materia>> GetAllAsync()
        {
            IEnumerable<Materia> materias = null;
            HttpResponseMessage response = await client.GetAsync("materias");
            if (response.IsSuccessStatusCode)
            {
                materias = await response.Content.ReadAsAsync<IEnumerable<Materia>>();
            }
            return materias;
        }

        public async static Task AddAsync(Materia materia)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("materias", materia);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("materias/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Materia materia)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("materias", materia);
            response.EnsureSuccessStatusCode();
        }
    }
}
