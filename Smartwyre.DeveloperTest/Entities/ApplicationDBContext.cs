using Microsoft.EntityFrameworkCore;

namespace Smartwyre.DeveloperTest.Entities
{
    public class ApplicationDBContext : DbContext
    {
        //protected readonly IConfiguration Configuration;

        //public ApplicationDBContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}