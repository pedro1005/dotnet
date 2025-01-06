using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbApp.Models;

namespace WebbApp.Data
{
    public class WebbappContext : DbContext
    {
        public WebbappContext (DbContextOptions<WebbappContext> options)
            : base(options)
        {
        }

        public DbSet<WebbApp.Models.Movie> Movie { get; set; } = default!;
    }
}
