using DTOs;

namespace WindowsForms.FormUser
{
    internal class UserApiClient
    {
        public static HttpClient client = ApiClientProvider.GetClient();

        public static async Task<User> GetAsync(int id)
        {
            User user = null;
            HttpResponseMessage response = await client.GetAsync("users/" + id);
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            return user;
        }

        public static async Task<IEnumerable<User>> GetAllAsync()
        {
            IEnumerable<User> users = null;
            HttpResponseMessage response = await client.GetAsync("users");
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<IEnumerable<User>>();
            }
            return users;
        }

        public async static Task AddAsync(User user)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("users", user);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("users/" + id);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(User user)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("users", user);
            response.EnsureSuccessStatusCode();
        }
    }
}
