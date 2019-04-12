using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Dispose.Models
{
    public class Service3 : IDisposable
    {
        public Service3()
        {
        }

        public void Dispose()
        {
            System.Diagnostics.Debug.WriteLine("*** Service3.Dispose");
        }
    }
}
