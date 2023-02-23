using Microsoft.EntityFrameworkCore;

namespace L8b.Models;

public class UsersDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}