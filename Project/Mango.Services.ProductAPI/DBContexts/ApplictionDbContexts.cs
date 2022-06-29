using Mango.Services.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DBContexts
{
    public class ApplictionDbContexts:DbContext
    {
        public ApplictionDbContexts(DbContextOptions<ApplictionDbContexts> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 1,
                ProductName = "Prateek",
                ProductDescription = " aeejwefjiwrnrnwe",
                Price = 24,
                ImageUrl = "",
                CotegoryName = "Apptizer"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 2,
                ProductName = "Prateek",
                ProductDescription = " aeejwefjiwrnrnwe",
                Price = 24,
                ImageUrl = "",
                CotegoryName = "Apptizer"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 3,
                ProductName = "Prateek",
                ProductDescription = " aeejwefjiwrnrnwe",
                Price = 24,
                ImageUrl = "",
                CotegoryName = "Apptizer"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 4,
                ProductName = "Raman Singh",
                ProductDescription = " aeejwefjiwrnrnwe",
                Price = 24,
                ImageUrl = "",
                CotegoryName = "Apptizer"

            });
        }
    }
}
