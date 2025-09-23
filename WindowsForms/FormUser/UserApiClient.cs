using DTOs.User;

namespace WindowsForms.FormUser
{
    internal class UserApiClient
    {
        public static HttpClient client = ApiClientProvider.GetClient();

        public static async Task<UserDTO> GetAsync(int id)
        {
            UserDTO user = null;
            HttpResponseMessage response = await client.GetAsync("users/" + id);
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<UserDTO>();
            }
            return user;
        }

        public static async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            IEnumerable<UserDTO> users = null;
            HttpResponseMessage response = await client.GetAsync("users");
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<IEnumerable<UserDTO>>();
            }
            return users;
        }

        public async static Task AddAsync(UserDTO user)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("users", user);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("users/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(UserDTO user)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("users", user);
            response.EnsureSuccessStatusCode();
        }
    }
}
