using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ML.Concept
{
    public class Startup_Simple
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Chain multiple delegates using 'Use'
            app.Use(async (context, next) =>
            {
                await next.Invoke();
            });

            // Terminates the middleware pipeline 'Run'
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World, This is from 2nd middleware");
            });
        }
    }
}
