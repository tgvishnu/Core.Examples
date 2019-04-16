using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Host.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //Application Key (Name)
                .UseSetting(WebHostDefaults.ApplicationKey, "Custom application name")
                // Capture Startup Errors
                .CaptureStartupErrors(true)
                // Content Root
                .UseContentRoot("C:\\Content")
                // use detail erros
                .UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddJsonFile("samplewebsettings", optional: true, reloadOnChange: true);
                })
                .ConfigureLogging((logging) =>
                {
                    // this setting overrides the settings in appsettings.Development.json (LogLevel.Debug) and appsettings.Production.json (LogLevel.Error) 
                    // configured by CreateDefaultBuilder. ConfigureLogging may be called multiple times.

                    logging.SetMinimumLevel(LogLevel.Warning);
                })
                .UseStartup<Startup>();
    }
}
