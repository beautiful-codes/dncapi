
using Microsoft.EntityFrameworkCore;
using dnc.api.Persistance.Models;
namespace dnc.api.Persistance
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}