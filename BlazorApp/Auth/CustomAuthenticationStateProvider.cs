using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Blazor.Server.Auth
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IAuthService _authService;

        public CustomAuthenticationStateProvider(IAuthService authService)
        {
            _authService = authService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                // Verificar expiración primero
                await _authService.CheckTokenExpirationAsync();

                var isAuthenticated = await _authService.IsAuthenticatedAsync();

                if (isAuthenticated)
                {
                    var username = await _authService.GetUsernameAsync();

                    if (!string.IsNullOrEmpty(username))
                    {
                        var identity = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name, username)
                        }, "custom");

                        var user = new ClaimsPrincipal(identity);
                        return new AuthenticationState(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en GetAuthenticationStateAsync: {ex.Message}");
            }

            // Si algo falla o no está autenticado, devolver anónimo
            var anonymous = new ClaimsPrincipal(new ClaimsIdentity());
            return new AuthenticationState(anonymous);
        }

        public void NotifyUserAuthentication(string username)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, username)
            }, "custom");

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void NotifyUserLogout()
        {
            var anonymous = new ClaimsPrincipal(new ClaimsIdentity());
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(anonymous)));
        }
    }
}