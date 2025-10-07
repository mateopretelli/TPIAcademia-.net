using ApiClients;
using DTOs;
using System.Net;

namespace WindowsForms.FormUser
{
    internal class UserApiClient : BaseApiClient
    {
        public static async Task<UserDTO> GetAsync(int id)
        {
            UserDTO user = null;
            using var client = await CreateHttpClientAsync();
            HttpResponseMessage response = await client.GetAsync("users/" + id);
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<UserDTO>();
            }
            return user;
        }

        public static async Task<UserDTO> GetByLegajoAsync(int legajo)
        {
            UserDTO user = null;
            using var client = await CreateHttpClientAsync();
            HttpResponseMessage response = await client.GetAsync($"users/legajo/{legajo}");
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<UserDTO>();
            }
            return user;
        }

        public static async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            IEnumerable<UserDTO> users = null;
            using var client = await CreateHttpClientAsync();
            HttpResponseMessage response = await client.GetAsync("users");
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<IEnumerable<UserDTO>>();
            }
            return users;
        }

        public static async Task<IEnumerable<UserDTO>> GetAllPerTypeAsync( int typeNumber)
        {
            IEnumerable<UserDTO> users = null;
            using var client = await CreateHttpClientAsync();
            HttpResponseMessage response = await client.GetAsync("usersType/" + typeNumber);
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<IEnumerable<UserDTO>>();
            }
            return users;
        }

        public async static Task AddAsync(UserDTO user)
        {
            using var client = await CreateHttpClientAsync();
            HttpResponseMessage response = await client.PostAsJsonAsync("users", user);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            using var client = await CreateHttpClientAsync();
            HttpResponseMessage response = await client.DeleteAsync("users/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(UserDTO user)
        {
            using var client = await CreateHttpClientAsync();
            HttpResponseMessage response = await client.PutAsJsonAsync("users", user);
            response.EnsureSuccessStatusCode();
        }

        public static async Task<bool> LoginAsync(UserLoginDTO dto)
        {
            using var client = await CreateHttpClientAsync();
            HttpResponseMessage response = await client.PostAsJsonAsync("users/login", dto);
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                return false;
            }

            response.EnsureSuccessStatusCode(); // lanza excepción si falla
            return true;
        }
    }
}
