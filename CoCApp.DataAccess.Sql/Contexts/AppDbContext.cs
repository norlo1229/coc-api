using CoCApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoCApp.DataAccess.Sql.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){ }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Log> Logs { get; set; }
    }
}
