using System.Net;
using System.Net.Http.Headers;

namespace ApiClients
{
    public abstract class BaseApiClient
    {
        protected static async Task<HttpClient> CreateHttpClientAsync()
        {
            var client = new HttpClient();
            await ConfigureHttpClientAsync(client);
            return client;
        }

        protected static Task ConfigureHttpClientAsync(HttpClient client)
        {
            string baseUrl = GetBaseUrlFromConfig();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            AddAuthorizationHeaderAsync(client); // Sin await

            return Task.CompletedTask;
        }
        private static readonly HttpClient client = new HttpClient();

        private static string GetBaseUrlFromConfig()
        {              

                // 1. Primero revisar variable de entorno
                string? envUrl = Environment.GetEnvironmentVariable("TPI_API_BASE_URL");
                if (!string.IsNullOrEmpty(envUrl))
                {
                    return envUrl;
                }

                // 2. Detectar si estamos en Android por el runtime
                string runtimeInfo = System.Runtime.InteropServices.RuntimeInformation.RuntimeIdentifier;

                if (runtimeInfo.StartsWith("android"))
                {
                    return "http://10.0.2.2:5183/";
                }

            // URL por defecto para Windows/otras plataformas
            string defaultUrl = "https://localhost:7005/";
            return defaultUrl;
        }

        protected static Task AddAuthorizationHeaderAsync(HttpClient client)
        {
                var token = AuthServiceProvider.GetToken();

                if (!string.IsNullOrEmpty(token))
                {
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token);
                }

            return Task.CompletedTask;
        }

        protected static async Task EnsureAuthenticatedAsync()
        {
            var authService = AuthServiceProvider.Instance;

            // Verificar expiración primero
            await authService.CheckTokenExpirationAsync();

            if (!await authService.IsAuthenticatedAsync())
            {
                throw new UnauthorizedAccessException("Su sesión ha expirado.");
            }
        }

        protected static async Task HandleUnauthorizedResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                // Limpiar sesión actual
                var authService = AuthServiceProvider.Instance;
                await authService.LogoutAsync();

                // Lanzar excepción con mensaje simple
                throw new UnauthorizedAccessException("Su sesión ha expirado.");
            }
        }
    }
}
