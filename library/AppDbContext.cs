using library_.Models;
using Microsoft.EntityFrameworkCore;

namespace library_
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authers { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }
    }
}
