using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ML.SampleExample
{
    internal class EnvironmentMiddleware
    {
        public EnvironmentMiddleware(RequestDelegate next, IHostingEnvironment environment)
        {
            this.Next = next;
            this.EnvironementName = environment.EnvironmentName;
        }

        public RequestDelegate Next { get; private set; }
        public string EnvironementName { get; private set; }

        public async Task Invoke(HttpContext context)
        {
            var myTimer = Stopwatch.StartNew();
            context.Response.Headers.Add("X-HostingEnvironmentName", new[] { EnvironementName });
            await Next(context);
            if(context.Request.ContentType != null && context.Request.ContentType.Contains("html"))
            {
                await context.Response.WriteAsync($"<p> from {EnvironementName} in {myTimer.ElapsedMilliseconds} ms </p>");
            }
        }
    }
}