using Microsoft.EntityFrameworkCore;
using SampleAcademy.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAcademy.Models.DataServices
{
    public class StudentDataContext : DbContext
    {
        public StudentDataContext(DbContextOptions<StudentDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CourseGrade> Grades { get; set; }
    }
}
