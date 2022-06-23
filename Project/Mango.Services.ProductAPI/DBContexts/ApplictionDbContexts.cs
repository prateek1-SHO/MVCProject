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
    }
}
