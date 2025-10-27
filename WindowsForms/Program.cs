using APIAuthWindowsForms;
using ApiClients;
using QuestPDF.Infrastructure;
using WindowsForms.Home;

namespace WindowsForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Handler para excepciones de UI no manejadas
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            // Registrar AuthService en singleton
            var authService = new WindowsFormsAuthService();
            AuthServiceProvider.Register(authService);

            // Loop principal de autenticación
            while (true)
            {

                if (!await authService.IsAuthenticatedAsync())
                {
                    var loginForm = new Login();
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        // Usuario canceló login, cerrar aplicación
                        return;
                    }
                }

                try
                {
                    var userRole = await authService.GetUserRoleAsync();

                    if (string.IsNullOrEmpty(userRole))
                    {
                        throw new UnauthorizedAccessException("No se pudo determinar el rol del usuario. Por favor, inicie sesión de nuevo.");
                    }

                    Form homeForm;
                    switch (userRole)
                    {

                        case "Admin":
                            homeForm = new AdminHome();
                            break;
                        case "Teacher":
                            homeForm = new TeacherHome();
                            break;
                        case "Student":
                            homeForm = new StudentHome();
                            break;
                        default:
                            throw new UnauthorizedAccessException($"Su cuenta tiene un rol no válido: {userRole}. Por favor, contacte al administrador.");
                    }
                    Application.Run(homeForm);
                    break; // La aplicación se cerró normalmente
                }
                catch (UnauthorizedAccessException ex)
                {
                    await authService.LogoutAsync();
                    // Sesión expirada, mostrar mensaje y volver al login
                    MessageBox.Show(ex.Message, "Sesión Expirada",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // El loop continuará y volverá a mostrar login
                }
            }
        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception is UnauthorizedAccessException)
            {
                // Sesión expirada
                MessageBox.Show("Su sesión ha expirado. Debe volver a autenticarse.", "Sesión Expirada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Reiniciar la aplicación para volver al login
                Application.Restart();
            }
            else
            {
                // Otras excepciones, mostrar error genérico
                MessageBox.Show($"Error inesperado: {e.Exception.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}