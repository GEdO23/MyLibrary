using Microsoft.EntityFrameworkCore;
using MyLibrary.Models;

namespace MyLibrary.Persistence;

public class OracleDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<ImageUrl> Images { get; set; }
    public DbSet<Publisher> Publishers { get; set; }

    public OracleDbContext(DbContextOptions<OracleDbContext> options) : base()
    {

    }
}