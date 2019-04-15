using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ML.FactoryBased.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseConventionalMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ConventionalMiddleware>();
        }

        public static IApplicationBuilder UseFactoryMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<FactoryActivatedMiddleware>();
        }
    }
}
