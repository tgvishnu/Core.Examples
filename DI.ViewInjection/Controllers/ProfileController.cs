using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.ViewInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI.ViewInjection.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var profile = new Profile()
            {
                Name = "Steve",
                Gender = "Female",
                FavColor = "Red",
                State = new State("Ohio", "OH")
            };

            return View(profile);
        }
    }
}