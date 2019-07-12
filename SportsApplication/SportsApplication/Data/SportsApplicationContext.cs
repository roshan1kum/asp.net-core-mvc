using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsApplication.Models;

namespace SportsApplication.Models
{
    public class SportsApplicationContext : DbContext
    {
        public SportsApplicationContext (DbContextOptions<SportsApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<SportsApplication.Models.Test> Test { get; set; }

        public DbSet<SportsApplication.Models.athlete> athlete { get; set; }
    }
}
