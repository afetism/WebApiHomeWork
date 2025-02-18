using FirstApiProject.Persistence.MiddlewareServices;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace FirstApiProject.Persistence.Middlewares;

public class RateLimitMiddleware(RequestDelegate next, RateLimitService rateLimitService)
{
    private readonly RequestDelegate _next = next;
    private readonly RateLimitService _rateLimitService = rateLimitService;

    public async Task InvokeAsync(HttpContext context)
    {
        var clientIp = context.Connection.RemoteIpAddress.ToString()??"unknown";
        if(!_rateLimitService.IsAllowedRequest(clientIp))
        {
            context.Response.StatusCode=(int)HttpStatusCode.TooManyRequests;
            await context.Response.WriteAsync("Too Many Request...Try later");
            return;
        }
        await _next(context);
    }
}
