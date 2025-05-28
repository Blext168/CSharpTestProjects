using DatabaseSQLTester.Model;
using Microsoft.EntityFrameworkCore;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace DatabaseSQLTester;

public class HandelsDbContext : DbContext
{
    public DbSet<Artikel> Artikel { get; set; }
    public DbSet<Lager> Lager { get; set; }
    public DbSet<Verkauf> Verkaufe { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=handel.db");
    }
}