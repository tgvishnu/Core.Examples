using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ML.SampleExample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Information);
            var logger = loggerFactory.CreateLogger("Middleware Demo");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<EnvironmentMiddleware>();

            app.UseStaticFiles();
            app.Use(async (context, next) =>
            {
                var myTimer = System.Diagnostics.Stopwatch.StartNew();
                logger.LogInformation($"--===> Beginning request is {env.EnvironmentName} environment");
                await next();
                logger.LogInformation($"--===> Request completed in {myTimer.ElapsedMilliseconds} ms");
            });
            app.Map("/stuff", appl => appl.Run(async (context) =>
           {
               context.Request.ContentType = "text/html";
               await context.Response.WriteAsync("This is your stuff");
           }));

            app.MapWhen(context => context.Request.Headers["User-Agent"].Contains("Apple-iphone"), iphoneRoute);

            app.Run(async (context) =>
            {
                context.Request.ContentType = "text/html";
                await context.Response.WriteAsync("Hello World!");
            });
        }

        private void iphoneRoute(IApplicationBuilder obj)
        {
            obj.Run(async (context) =>
            {
                await context.Response.WriteAsync("Iphone agent");
            });
        }
    }
}
