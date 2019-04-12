using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Dispose.Interfaces;
using DI.Dispose.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI.Dispose.Controllers
{
    public class HomeController : Controller
    {
        private readonly Service1 _service1;
        private readonly Service2 _service2;
        private readonly Service3 _service3;
        private readonly ISomeService _someService;
        public HomeController(Service1 service1, Service2 service2, Service3 service3, ISomeService someService)
        {
            _service1 = service1;
            _service2 = service2;
            _service3 = service3;
            _someService = someService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}