using DI.Simple.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Simple.Services
{
    public class MyDependencyService : IMyDependency
    {
        private readonly ILogger<MyDependencyService> _logger;

        public MyDependencyService(ILogger<MyDependencyService> logger)
        {
            _logger = logger;
        }

        public Task WriteMessage(string message)
        {
            _logger.LogInformation("MyDependency.WriteMessage called. Message: {MESSAGE}", message);
            return Task.FromResult(0);
        }
    }
}
