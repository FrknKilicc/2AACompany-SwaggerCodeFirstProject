using Microsoft.EntityFrameworkCore;
namespace _2AACompany_SwaggerCodeFirstProject.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orderr> Orders { get; set; }
        public DbSet<Productt> Products { get; set; }



    }
}

