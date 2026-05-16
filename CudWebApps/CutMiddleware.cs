using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CudWebApps
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CutMiddleware
    {
        private readonly RequestDelegate _next;

        public CutMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("This is custom middleware");
            //return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CutMiddlewareExtensions
    {
        public static IApplicationBuilder UseCutMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CutMiddleware>();
        }
    }
}
