using DI.ViewInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.ViewInjection.Models.Services
{
    public class StatasticsService
    {
        private readonly IToDoItemRepository _todoItemRepository;

        public StatasticsService(IToDoItemRepository toDoItemRepository)
        {
            _todoItemRepository = toDoItemRepository;
        }

        public int GetCount()
        {
            return _todoItemRepository.List().Count();
        }

        public int GetCompletedCount()
        {
            return _todoItemRepository.List().Count(x => x.IsDone);
        }

        public double GetAveragePriority()
        {
            if(_todoItemRepository.List().Count() == 0)
            {
                return 0.0;
            }

            return _todoItemRepository.List().Average(x => x.Priority);
        }
    }
}
