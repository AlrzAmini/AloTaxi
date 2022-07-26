
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace AloTaxi.Application.Utilities.Extensions
{
    public static class HttpExtensions
    {
        public static string GetUserIp(this HttpContext httpContext)
        {
            return httpContext.Connection.RemoteIpAddress.ToString();
        }

        public static string GetCurrentUrl(this HttpContext httpContext)
        {
            return $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.Path}{httpContext.Request.QueryString}";
        }

        public static int GetUserId(this ClaimsPrincipal claim)
        {
            var data = claim.Claims.SingleOrDefault(s => s.Type == ClaimTypes.NameIdentifier);
            return data != null ? Convert.ToInt32(data.Value) : default;
        }
    }
}
