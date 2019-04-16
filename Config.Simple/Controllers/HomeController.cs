using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Config.Simple.Models;
using Microsoft.Extensions.Configuration;

namespace Config.Simple.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _configuration;
        public IActionResult Index()
        {
            return View();
        }

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult FromMemory()
        {
            var arrayList = _configuration.GetSection("array").Get<ArrayListExample>();
            return View(arrayList);
        }

        public IActionResult FromJson()
        {
            var jsonContent = _configuration.GetSection("json_array").Get<JsonArrayExample>();
            return View(jsonContent);
        }

        public IActionResult FromJsonToClass()
        {
            var classContent = _configuration.GetSection("starship").Get<Starship>();
            return View(classContent);
        }
       
    }
}
