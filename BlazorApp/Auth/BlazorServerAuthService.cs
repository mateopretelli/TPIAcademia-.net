using DTOs;
using Microsoft.JSInterop;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Blazor.Server.Auth
{
    public class BlazorServerAuthService : IAuthService
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly IHttpClientFactory _httpClientFactory;
        private const string TOKEN_KEY = "auth_token";
        private const string USERNAME_KEY = "auth_username";
        private const string EXPIRES_AT_KEY = "auth_expires_at";
        private const string API_BASE_URL = "https://localhost:7005/";

        private string? _cachedToken;
        private string? _cachedUsername;
        private DateTime? _cachedExpiresAt;

        public BlazorServerAuthService(IJSRuntime jsRuntime, IHttpClientFactory httpClientFactory)
        {
            _jsRuntime = jsRuntime;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(API_BASE_URL);

                var loginRequest = new LoginRequestDTO
                {
                    Username = username,
                    Password = password
                };

                var json = JsonSerializer.Serialize(loginRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("auth/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseContent, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (loginResponse != null)
                    {
                        // Guardar en localStorage
                        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", TOKEN_KEY, loginResponse.Token);
                        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", USERNAME_KEY, loginResponse.Username);
                        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", EXPIRES_AT_KEY, loginResponse.ExpiresAt.ToString("o"));

                        // Cachear en memoria
                        _cachedToken = loginResponse.Token;
                        _cachedUsername = loginResponse.Username;
                        _cachedExpiresAt = loginResponse.ExpiresAt;

                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en LoginAsync: {ex.Message}");
                throw;
            }
        }

        public async Task LogoutAsync()
        {
            try
            {
                // Limpiar localStorage
                await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", TOKEN_KEY);
                await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", USERNAME_KEY);
                await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", EXPIRES_AT_KEY);

                // Limpiar caché
                _cachedToken = null;
                _cachedUsername = null;
                _cachedExpiresAt = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en LogoutAsync: {ex.Message}");
            }
        }

        public async Task<bool> IsAuthenticatedAsync()
        {
            var token = await GetTokenAsync();

            if (string.IsNullOrEmpty(token))
                return false;

            // Verificar expiración
            await CheckTokenExpirationAsync();

            // Verificar nuevamente después de check
            token = await GetTokenAsync();
            return !string.IsNullOrEmpty(token);
        }

        public async Task<string?> GetTokenAsync()
        {
            try
            {
                if (!string.IsNullOrEmpty(_cachedToken))
                    return _cachedToken;

                _cachedToken = await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", TOKEN_KEY);
                return _cachedToken;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en GetTokenAsync: {ex.Message}");
                return null;
            }
        }

        public async Task<string?> GetUsernameAsync()
        {
            try
            {
                if (!string.IsNullOrEmpty(_cachedUsername))
                    return _cachedUsername;

                _cachedUsername = await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", USERNAME_KEY);
                return _cachedUsername;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en GetUsernameAsync: {ex.Message}");
                return null;
            }
        }

        public async Task CheckTokenExpirationAsync()
        {
            try
            {
                if (_cachedExpiresAt.HasValue)
                {
                    if (DateTime.UtcNow >= _cachedExpiresAt.Value)
                    {
                        await LogoutAsync();
                        return;
                    }
                }

                var expiresAtStr = await _jsRuntime.InvokeAsync<string?>("localStorage.getItem", EXPIRES_AT_KEY);

                if (!string.IsNullOrEmpty(expiresAtStr) && DateTime.TryParse(expiresAtStr, out var expiresAt))
                {
                    _cachedExpiresAt = expiresAt;

                    if (DateTime.UtcNow >= expiresAt)
                    {
                        await LogoutAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en CheckTokenExpirationAsync: {ex.Message}");
            }
        }
    }
}