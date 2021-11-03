using Microsoft.EntityFrameworkCore;
using commander_graphql.Models;

namespace commander_graphql.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}