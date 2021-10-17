using manga_library.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace manga_library.Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Readers> Readers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}