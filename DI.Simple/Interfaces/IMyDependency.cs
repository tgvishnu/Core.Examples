﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Simple.Interfaces
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}
