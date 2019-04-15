using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ML.FactoryBased.Data;
using ML.FactoryBased.Models;

namespace ML.FactoryBased.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var requests = _db.Requests.ToList();
            return View(requests);
        }
    }
}
