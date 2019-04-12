using DI.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.States.Models
{
    public class Operation : IOperation, IOperationScoped, IOperationSingleton, IOperationSingletonInstance, IOperationTransient
    {
        public Operation()
            : this(Guid.NewGuid())
        {
        }

        public Operation(Guid guid)
        {
            this.OperationId = guid;
        }

        public Guid OperationId { get; }
    }
}
