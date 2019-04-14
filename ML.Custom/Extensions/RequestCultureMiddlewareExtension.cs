using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ML.Custom.Middleware
{
    public static class RequestCultureMiddlewareExtension
    {
        public static IApplicationBuilder UseRequestCulture(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RequestCultureMiddleware>();
        }
    }
}
