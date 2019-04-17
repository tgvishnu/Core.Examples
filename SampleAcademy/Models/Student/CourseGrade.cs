using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAcademy.Models.Student
{
    public class CourseGrade
    {
        public long Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "Course")]
        public string CourseName { get; set; }

        [StringLength(500)]
        [Display(Name = "Professor")]
        public string ProfessorName { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]
        [Display(Name = "Student Username")]
        public string StudentUserName { get; set; }
        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }
    }
}
