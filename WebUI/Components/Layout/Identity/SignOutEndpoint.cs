using Application.Extensions.Identity;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace WebUI.Components.Layout.Identity
{
    internal static class SignOutEndpoint
    {
        public static IEndpointConventionBuilder MapSignOutEndpoint(this IEndpointRouteBuilder endpoint)
        {
            ArgumentNullException.ThrowIfNull(endpoint);
            var accountGroup = endpoint.MapGroup("/Account");
            accountGroup.MapPost("/Logout", async (ClaimsPrincipal user, SignInManager<ApplicationUser> signInManager) =>
            {
                await signInManager.SignOutAsync();
                return TypedResults.LocalRedirect("/Account/Login");
            });
            return accountGroup;
        }
    }
}
