using ReShareBlazorApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ReShareBlazorApp.Data
{
    public class ReShareDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ReShareDbContext(DbContextOptions<ReShareDbContext> options) 
            : base(options)
        {
        }
    }
}
