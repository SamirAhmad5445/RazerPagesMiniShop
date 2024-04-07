using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazerPagesMiniShop.Models;

namespace RazerPagesMiniShop.Data
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<Company> Companies { get; set; }
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder mb)
    {
      mb.Entity<Company>().HasData(
          new Company { Id = 1, Name = "Nike" },
          new Company { Id = 2, Name = "Adidias" }
      );
    }
  }
}
