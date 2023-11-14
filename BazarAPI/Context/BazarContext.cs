using Microsoft.EntityFrameworkCore;
using BazarAPI.Models;

namespace BazarAPI.Context
{
    public class BazarContext : DbContext
    {
        public BazarContext(DbContextOptions<BazarContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
