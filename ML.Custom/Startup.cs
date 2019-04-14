using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ML.Custom.Middleware;

namespace ML.Custom
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // example : http://localhost:50829/?culture=IT
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Middleware is constructed once per application lifetime.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRequestCulture();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Hello World! culture is {CultureInfo.CurrentCulture.DisplayName} ");
            });
        }
    }
}
