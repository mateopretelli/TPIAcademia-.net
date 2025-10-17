namespace Blazor.Server.Auth
{
    public static class AuthServiceProvider
    {
        private static IAuthService? _instance;

        public static IAuthService Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new InvalidOperationException(
                        "AuthServiceProvider no ha sido inicializado. " +
                        "Llame a AuthServiceProvider.Register(authService) en Program.cs");
                }
                return _instance;
            }
        }

        public static void Register(IAuthService authService)
        {
            _instance = authService;
        }
    }
}