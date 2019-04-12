using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.ViewInjection.Models.Services
{
    public class ProfileOptionsService
    {
        public IList<string> ListGenders()
        {
            return new List<string>() { "Female", "Male" };
        }

        public IList<State> ListStates()
        {
            return new List<State>()
            {
                new State("Alabama", "AL"),
                new State("Alaska", "AK"),
                new State("Ohio", "OH")
            };
        }

        public IList<string> ListColors()
        {
            return new List<string>() { "Blue", "Green", "Red", "Yellow" };
        }
    }
}
