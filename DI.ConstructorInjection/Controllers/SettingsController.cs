using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.ConstructorInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DI.ConstructorInjection.Controllers
{
    public class SettingsController : Controller
    {
        private readonly SampleWebSettings _sampleWebSettings;

        public SettingsController(IOptions<SampleWebSettings> options)
        {
            _sampleWebSettings = options.Value;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = _sampleWebSettings.Title;
            ViewData["Updates"] = _sampleWebSettings.Updates;
            return View();
        }
    }
}