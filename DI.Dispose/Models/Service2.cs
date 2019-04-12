using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Dispose.Models
{
    public class Service2 : IDisposable
    {
        private readonly ILogger<Service2> _logger;
        public Service2(ILogger<Service2> logger)
        {
            _logger = logger;
        }

        public void Dispose()
        {
            _logger.LogInformation("*** Service2.Dispose");
        }
    }
}
