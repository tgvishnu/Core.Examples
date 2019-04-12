using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.ConstructorInjection.Interfaces
{
    public interface IDateTime
    {
        DateTime Now { get;  }
    }
}
