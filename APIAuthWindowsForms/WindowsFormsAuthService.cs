using ApiClients;
using DTOs;
using System.IdentityModel.Tokens.Jwt;

namespace APIAuthWindowsForms
{
    public class WindowsFormsAuthService : IAuthService
    {
        private static string? _currentToken;
        private static DateTime _tokenExpiration;
        private static string? _currentUsername;

        public event Action<bool>? AuthenticationStateChanged;

        public async Task<bool> IsAuthenticatedAsync()
        {
            return !string.IsNullOrEmpty(_currentToken) && DateTime.UtcNow < _tokenExpiration;
        }

        public async Task<string?> GetTokenAsync()
        {
            var isAuth = await IsAuthenticatedAsync();
            return isAuth ? _currentToken : null;
        }

        public async Task<string?> GetUsernameAsync()
        {
            var isAuth = await IsAuthenticatedAsync();
            return isAuth ? _currentToken : null;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var request = new LoginRequestDTO
            {
                Username = username,
                Password = password
            };

            var authClient = new AuthApiClient();
            var response = await authClient.LoginAsync(request);

            if (response != null)
            {
                _currentToken = response.Token;
                _tokenExpiration = response.ExpiresAt;
                _currentUsername = response.Username;

                AuthenticationStateChanged?.Invoke(true);
                return true;
            }

            return false;
        }

        public async Task LogoutAsync()
        {
            _currentToken = null;
            _tokenExpiration = default;
            _currentUsername = null;

            AuthenticationStateChanged?.Invoke(false);
        }

        public async Task CheckTokenExpirationAsync()
        {
            if (!string.IsNullOrEmpty(_currentToken) && DateTime.UtcNow >= _tokenExpiration)
            {
                await LogoutAsync();
            }
        }

        public async Task<string?> GetUserRoleAsync()
        {
            var isAuth = await IsAuthenticatedAsync();
            if (!isAuth || string.IsNullOrEmpty(_currentToken))
                return null;

            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(_currentToken);

                var roleClaim = jwtToken.Claims.FirstOrDefault(c =>
                c.Type == System.Security.Claims.ClaimTypes.Role ||
                c.Type == "role" ||
                c.Type == "Role");

                if (roleClaim != null)
                {
                    switch (roleClaim.Value)
                    {
                        case "1":
                            return "Admin";
                        case "2":
                            return "Teacher";
                        case "3":
                            return "Student";
                        default:
                            return null;
                    }
                }
                return null;

            }
            catch
            {
                return null;
            }
        }
    }
}
