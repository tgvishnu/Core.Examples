using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.ViewInjection.Models
{
    public class State
    {
        public State(string name, string code)
        {
            this.Name = name;
            this.Code = code;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
