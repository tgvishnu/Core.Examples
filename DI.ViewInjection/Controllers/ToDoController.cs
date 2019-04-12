using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.ViewInjection.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DI.ViewInjection.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemRepository _todoItemRepository;

        public ToDoController(IToDoItemRepository toDoItemRepository)
        {
            _todoItemRepository = toDoItemRepository;
        }

        public IActionResult Index()
        {
            var result = _todoItemRepository.List();
            return View(result);
        }
    }
}