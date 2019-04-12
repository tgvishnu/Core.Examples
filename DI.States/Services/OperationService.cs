using DI.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.States.Services
{
    public class OperationService
    {
        public OperationService(IOperationTransient operationTransient, IOperationScoped operationScoped, IOperationSingleton operationSingleton, IOperationSingletonInstance operationSingletonInstance)
        {
            this.OperationTransient = operationTransient;
            this.OperationScoped = operationScoped;
            this.OperationSingleton = operationSingleton;
            this.OperationSingletonInstance = operationSingletonInstance;
        }

        public IOperationScoped OperationScoped { get; }
        public IOperationSingleton OperationSingleton { get; }
        public IOperationSingletonInstance OperationSingletonInstance { get; }
        public IOperationTransient OperationTransient { get; }
    }
}
