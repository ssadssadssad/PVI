using Microsoft.EntityFrameworkCore;

namespace L8b.Models;

public class Users
{
    private readonly UsersDbContext _dbContext;

    /// <summary>
    /// Users list
    /// </summary>
    public List<User> UsersList { get; set; }

    public Users(UsersDbContext dbContext)
    {
        _dbContext = dbContext;
        UsersList = dbContext.Users.AsNoTracking().ToList();
    }

    public Users GetAll()
    {
        UsersList = _dbContext.Users.AsNoTracking().ToList();
        return this;
    }

    public User? GetById(int id)
    {
        return _dbContext.Users.Find(id);
    }

    public User? Add(User user)
    {
        _dbContext.Users.Add(user);
        try
        {
            _dbContext.SaveChanges();
        }
        catch (Exception e) when (e is DbUpdateException or DbUpdateConcurrencyException)
        {
            return null;
        }

        return user;
    }

    public User? Update(User user)
    {
        var record = _dbContext.Users.Find(user.Id);
        if (record == null) return null;
        record.firstname = user.firstname;
        record.lastname = user.lastname;
        record.email = user.email;
        record.password = user.password;
        record.status = user.status;
        record.role = user.role;
        _dbContext.Users.Attach(record);
        _dbContext.Entry(record).State = EntityState.Modified;
        try
        {
            _dbContext.SaveChanges();
        }
        catch (Exception e) when (e is DbUpdateException or DbUpdateConcurrencyException)
        {
            return null;
        }

        return user;
    }

    public User? Delete(int id)
    {
        var record = _dbContext.Users.Find(id);
        if (record == null) return null;
        _dbContext.Entry(record).State = EntityState.Deleted;
        return record;
    }
}