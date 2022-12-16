using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Eno.Models;

namespace Eno.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Eno.Models.Films> Film { get; set; }
        public DbSet<Eno.Models.Theatres> Theatre { get; set; }
        public DbSet<Eno.Models.FilmTheatres> FilmTheatre { get; set; }
    }
}