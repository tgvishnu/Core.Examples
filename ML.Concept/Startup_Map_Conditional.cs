using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ML.Concept
{
    public class Startup_Map_Conditional
    {
        //example : http://localhost:49970/?branch=master
        public static void HandleBranch(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var branchVer = context.Request.Query["branch"];
                await context.Response.WriteAsync($"Branch used = {branchVer}");
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.MapWhen(
                context => context.Request.Query.ContainsKey("branch"),
                HandleBranch);

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from non-Map delegate. <p>");
            });
        }
    }
}
