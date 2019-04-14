using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ML.Concept
{
    public class Startup_Map
    {
        public static void HandleMapTest1(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test 1");
            });
        }

        public static void HandleMapTest2(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test 2");
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            //Map extensions are used as a convention for branching the pipeline. 
            //Map* branches the request pipeline based on matches of the given request path.
            //If the request path starts with the given path, the branch is executed.
            app.Map("/map1", HandleMapTest1);
            app.Map("/map2", HandleMapTest2);
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from non-Map delegate. <p>");
            });
        }
    }
}
