using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Blazor.Server.Auth
{
    public class AuthenticatedComponentBase : ComponentBase
    {
        [Inject]
        protected IAuthService AuthService { get; set; } = default!;

        [Inject]
        protected IJSRuntime JSRuntime { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            await JSRuntime.InvokeVoidAsync("console.log", "🔥 AuthenticatedComponentBase - INICIO");
            await JSRuntime.InvokeVoidAsync("console.log", $"🔥 AuthService es null? {AuthService == null}");

            if (AuthService != null)
            {
                // Obtener el token y registrarlo
                var token = await AuthService.GetTokenAsync();
                if (!string.IsNullOrEmpty(token))
                {
                    ApiClients.AuthServiceProvider.RegisterToken(token);
                    await JSRuntime.InvokeVoidAsync("console.log", "🔥 Token REGISTRADO en base");
                }
                else
                {
                    await JSRuntime.InvokeVoidAsync("console.log", "⚠️ Token está vacío");
                }
            }

            await base.OnInitializedAsync();
        }
    }
}