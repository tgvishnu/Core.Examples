﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Config.Simple
{
    public class Program
    {
        public static Dictionary<string, string> arrayDict = new Dictionary<string, string>
            {
                {"array:entries:0", "value0"},
                {"array:entries:1", "value1"},
                {"array:entries:2", "value2"},
                {"array:entries:4", "value4"},
                {"array:entries:5", "value5"}
            };

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddInMemoryCollection(arrayDict);
                    config.AddJsonFile("missing_array.json");
                    config.AddJsonFile("json_array.json", optional: false, reloadOnChange: false);
                })
                .UseStartup<Startup>();
    }
}
