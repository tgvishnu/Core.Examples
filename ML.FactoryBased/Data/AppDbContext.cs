using Microsoft.EntityFrameworkCore;
using ML.FactoryBased.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ML.FactoryBased.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Request> Requests { get; set; }
    }
}
