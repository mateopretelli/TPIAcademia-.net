namespace ApiClients
{
    public static class AuthServiceProvider
    {
        private static string? _cachedToken;
        private static IAuthService? _instance;
        private static readonly object _lock = new object();

        // Para Blazor Server - Registrar token directamente
        public static void RegisterToken(string token)
        {
            lock (_lock)
            {
                _cachedToken = token;
            }
        }

        // Obtener token (sincrónico) - Intenta primero el token cacheado, luego del IAuthService
        public static string? GetToken()
        {
            lock (_lock)
            {
                // Si hay token cacheado (de Blazor), usarlo
                if (!string.IsNullOrEmpty(_cachedToken))
                    return _cachedToken;

                // Si no, intentar obtenerlo del IAuthService (Windows Forms)
                if (_instance != null)
                {
                    // Llamar al método async de forma sincrónica (solo para Windows Forms)
                    try
                    {
                        return _instance.GetTokenAsync().GetAwaiter().GetResult();
                    }
                    catch
                    {
                        return null;
                    }
                }

                return null;
            }
        }

        // Para Windows Forms - Registrar IAuthService completo
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
                _cachedToken = null; // Limpiar token cacheado cuando se registra un IAuthService
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