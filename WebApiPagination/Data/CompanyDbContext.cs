using Microsoft.EntityFrameworkCore;
using WebApiPagination.Entities.Models;

namespace WebApiPagination.Data
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
            :base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
