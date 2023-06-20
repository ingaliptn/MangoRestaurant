using Mango.Services.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.API.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}

