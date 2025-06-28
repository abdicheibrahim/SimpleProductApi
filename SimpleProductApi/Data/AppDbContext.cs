using Microsoft.EntityFrameworkCore;
using SimpleProductApi.Models;
using System.Collections.Generic;

namespace SimpleProductApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
    }
}
