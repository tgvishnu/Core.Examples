using DI.ViewInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.ViewInjection.Interfaces
{
    public interface IToDoItemRepository
    {
        IEnumerable<ToDoItem> List();
    }
}
