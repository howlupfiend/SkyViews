using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SkyViews.Models
{
    public class SkyViewsContext : DbContext
    {
        public SkyViewsContext (DbContextOptions<SkyViewsContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Showing> Showing { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Film>().ToTable("Film");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<Showing>().ToTable("Showing");
        }
    }
}
