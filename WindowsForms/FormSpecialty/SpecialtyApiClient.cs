using DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace WindowsForms.FormSpecialty
{
    internal class SpecialtyApiClient
    {
        private static HttpClient client = ApiClientProvider.GetClient();

        public static async Task<Specialty> GetAsync(int id)
        {
            Specialty specialty = null;
            HttpResponseMessage response = await client.GetAsync("specialties/" + id);
            if (response.IsSuccessStatusCode)
            {
                specialty = await response.Content.ReadAsAsync<Specialty>();
            }
            return specialty;
        }

        public static async Task<IEnumerable<Specialty>> GetAllAsync()
        {
            IEnumerable<Specialty> specialities = null;
            HttpResponseMessage response = await client.GetAsync("specialties");
            if (response.IsSuccessStatusCode)
            {
                
                specialities = await response.Content.ReadAsAsync<IEnumerable<Specialty>>();
            }
            /*specialities.ToList();
            foreach (var specialty in specialities)
            {
                Debug.WriteLine(specialty.ID);
            }*/
            return specialities;
        }

        public async static Task AddAsync(Specialty specialty)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("specialties", specialty);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("specialties/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(Specialty specialty)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("specialties", specialty);
            response.EnsureSuccessStatusCode();
        }
    }
}
