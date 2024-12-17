using HospitalManager.API.Services;
using Microsoft.AspNetCore.Authorization;

namespace HospitalManager.API.Middlewares;

public class AuthServiceMiddleware
{
    private readonly RequestDelegate _next;

    public AuthServiceMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IAuthenticationService authenticationService)
    {
        var endpoint = context.GetEndpoint();
        var hasAuthorizeAttribute = endpoint?.Metadata?.GetMetadata<AuthorizeAttribute>() != null;

        if (hasAuthorizeAttribute)
        {
            await authenticationService.CheckIfUserSubRegistered();
        }

        await _next(context);
    }
}
