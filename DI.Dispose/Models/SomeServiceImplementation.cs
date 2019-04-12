using DI.Dispose.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Dispose.Models
{
    public class SomeServiceImplementation : ISomeService, IDisposable
    {
        public SomeServiceImplementation()
        {
        }

        public void Dispose()
        {
            System.Diagnostics.Debug.WriteLine("*** SomeServiceImplementation.Dispose");
        }
    }
}
