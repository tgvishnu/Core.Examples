using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_Plus_Sports.Models
{
    public class H_Plus_SportsContext : DbContext
    {
        public H_Plus_SportsContext(DbContextOptions<H_Plus_SportsContext> options)
            :base(options)
        {
        }
    }
}
