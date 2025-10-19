namespace ApiClients
{
    public static class AuthServiceProvider
    {
        private static string? _cachedToken;
        private static readonly object _lock = new object();

        // NUEVO: Para Blazor Server
        public static void RegisterToken(string token)
        {
            lock (_lock)
            {
                _cachedToken = token;
            }
        }

        public static string? GetToken()
        {
            lock (_lock)
            {
                return _cachedToken;
            }
        }

        // MANTENER: Para compatibilidad con Windows Forms
        private static IAuthService? _instance;

        public static IAuthService Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new InvalidOperationException(
                        "AuthService has not been registered. Call AuthServiceProvider.Register() first.");
                }
                return _instance;
            }
        }

        public static void Register(IAuthService authService)
        {
            lock (_lock)
            {
                _instance = authService;
            }
        }

        public static void Clear()
        {
            lock (_lock)
            {
                _instance = null;
                _cachedToken = null;
            }
        }
    }
}