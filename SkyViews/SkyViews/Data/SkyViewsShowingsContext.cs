using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SkyViews.Models
{
    public class SkyViewsShowingsContext : DbContext
    {
        public SkyViewsShowingsContext (DbContextOptions<SkyViewsShowingsContext> options)
            : base(options)
        {
        }

        public DbSet<Showing> Showing { get; set; }
    }
}
