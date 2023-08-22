using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.NetCore6Demo.Models;

namespace Asp.NetCore6Demo.Data
{
    public class AspNetCore6DemoContext : DbContext
    {
        public AspNetCore6DemoContext (DbContextOptions<AspNetCore6DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Asp.NetCore6Demo.Models.Movie> Movie { get; set; } = default!;
    }
}
