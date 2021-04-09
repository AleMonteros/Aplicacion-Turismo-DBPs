using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppSocialTour.Models;
namespace AppSocialTour.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<RestBar> RestBar { get; set; }
        public DbSet<Social> Social { get; set; }
        public DbSet<Historia> Historia { get; set; }
        public DbSet<Novedad> Novedad { get; set; } 
        public DbSet<Promocion> Promocion { get; set;}
    }
}
