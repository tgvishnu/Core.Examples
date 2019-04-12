using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.ViewInjection.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public State State { get; set; }
        public string FavColor { get; set; }
    }
}
