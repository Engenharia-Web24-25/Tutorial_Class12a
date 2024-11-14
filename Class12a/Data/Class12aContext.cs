using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Class12a.Models;

namespace Class12a.Data
{
    public class Class12aContext : DbContext
    {
        public Class12aContext (DbContextOptions<Class12aContext> options)
            : base(options)
        {
        }

        public DbSet<Class12a.Models.Continent> Continent { get; set; } = default!;
        public DbSet<Class12a.Models.Country> Country { get; set; } = default!;
    }
}
