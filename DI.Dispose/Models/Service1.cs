using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Dispose.Models
{
    public class Service1 : IDisposable
    {
        private readonly ILogger<Service1> _logger;
        public Service1(ILogger<Service1> logger)
        {
            _logger = logger;
        }

        public void Dispose()
        {
            _logger.LogInformation("*** Service1.Dispose");
        }
    }
}
