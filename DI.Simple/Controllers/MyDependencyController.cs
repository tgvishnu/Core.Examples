using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Simple.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DI.Simple.Controllers
{
    public class MyDependencyController : Controller
    {
        private readonly IMyDependency _myDependency;

        public MyDependencyController(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }

        public async Task<IActionResult> Index()
        {
            await _myDependency.WriteMessage("MyDependencyController.Index created this message");
            return View();
        }
    }
}