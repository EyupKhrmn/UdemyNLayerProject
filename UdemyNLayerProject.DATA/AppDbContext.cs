using Microsoft.EntityFrameworkCore;
using UdemyNlayerProject.CORE.Model;
using UdemyNLayerProject.DATA.Configurations;

namespace UdemyNLayerProject.DATA
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}