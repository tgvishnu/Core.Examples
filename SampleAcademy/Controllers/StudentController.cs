using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleAcademy.Models.DataServices;
using SampleAcademy.Models.Student;

namespace SampleAcademy.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDataContext _db;

        public StudentController(StudentDataContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_db.Grades.ToList());
        }

        [HttpGet]
        public IActionResult AddGrade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGrade(CourseGrade courseGrade)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            courseGrade.CreatedDate = DateTime.Now;
            _db.Grades.Add(courseGrade);
            _db.SaveChanges();
            return RedirectToAction(nameof(StudentController.Index), "Student");
        }

        [HttpGet]
        public IActionResult Classifications()
        {
            var classifications = new List<string>()
            {
                "Freshman",
                "Sophomore",
                "Junior",
                "Senior"
            };

            return View(classifications);
        }
    }
}