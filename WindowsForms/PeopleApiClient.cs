using DTOs;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WindowsForms
{
    internal class PeopleApiClient
    {
        private static HttpClient client = ApiClientProvider.GetClient();

        public static async Task<Person> GetAsync(int id)
        {
            Person person = null;
            HttpResponseMessage response = await client.GetAsync("people/" + id);
            if (response.IsSuccessStatusCode)
            {
                person = await response.Content.ReadAsAsync<Person>();
            }
            return person;
        }

        public static async Task<IEnumerable<Person>> GetAllAsync()
        {
            IEnumerable<Person> people = null;
            HttpResponseMessage response = await client.GetAsync("people");
            if (response.IsSuccessStatusCode)
            {
                people = await response.Content.ReadAsAsync<IEnumerable<Person>>();
            }
            return people;
        }

        public static async Task<bool> AddAsync(Person person)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("people", person);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> UpdateAsync(Person person)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("people/" + person.ID, person);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("people/" + id);
            return response.IsSuccessStatusCode;
        }

    }
}
