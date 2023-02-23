using L8a.Models;
using Microsoft.EntityFrameworkCore;

namespace L8a.Sql;

public class PhoneDirectoryContext : DbContext
{
    public DbSet<PhoneDirectoryRecord> PhoneDirectory { get; set; }
        
    public PhoneDirectoryContext(DbContextOptions<PhoneDirectoryContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PhoneDirectoryRecord>().ToTable("PhoneDirectory")
            .HasKey(record => record.Id);
        modelBuilder.Entity<PhoneDirectoryRecord>().Property(record => record.Id)
            .ValueGeneratedOnAdd();
    }
}